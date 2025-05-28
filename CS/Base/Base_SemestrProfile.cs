using CRUDAppProject.CS.Interfaces;
using CRUDAppProject.CS.Side;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Base
{
    /// <summary>
    /// Klasa implementująca logikę profili i logowania
    /// </summary>

    internal class Base_SemestrProfile : ISerialize
    {
        /// <summary>
        /// Nazwa profilu z zapisanymi przedmiotami i zadaniami, którym zarządza użytkownik
        /// </summary>

        private string _name;
        public string Name
        {
            get { return this._name; }
            set
            {
                if (value.Length > 32)
                    throw new ArgumentException("Nazwa profilu jest za długa!", "TooLongProfileName");

                else
                    this._name = Side_Format.CapitalizeString(value);
            }
        }
              

        /// <summary>
        /// Nazwa folderu wewnątrz którego dane powstałe w aplikacji zostaną zapisane
        /// </summary>

        public const string NameOfAppDataFolder = "CRUDA";


        /// <summary>
        /// Lista przedmiotów typu matematyka, fizyka, chemia itd.
        /// </summary>

        private List<string> _listOfSubjects;
        public List<string> ListOfSubjects
        {
            get { return this._listOfSubjects; }
            set { this._listOfSubjects = value; }
        }



        // Są to skrócone zapisy ścieżek do folderu appdata i folderu aplikacji 

        public static string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string CrudaFolderPath = Path.Combine(AppDataPath, NameOfAppDataFolder);


        /// <summary>
        /// Zapisywanie danych związanych z profilem i listą przedmiotów do pliku .json 
        /// </summary>

        public void SaveDataToFile()
        {
            if (!Directory.Exists(CrudaFolderPath))
                Directory.CreateDirectory(CrudaFolderPath);

            if (string.IsNullOrWhiteSpace(this.Name))
                throw new ArgumentException("Profil nie ma żadnej nazwy!", "NullOrEmptyFileName");

            if (this.ListOfSubjects == null || this.ListOfSubjects.Count == 0)
                throw new ArgumentException("Lista przedmiotów jest pusta!", "EmptyListOfSubjects");

            string filePath = Path.Combine(CrudaFolderPath, this.Name + ".json");

            if (File.Exists(filePath))
                throw new ArgumentException("Profil istnieje!", "FileAlreadyExists");

            // Przygotowanie profilu
            var profile = new
            {
                listOfSubjects = this.ListOfSubjects
            };

            // Dodanie listy "tasks" do profilu
            List<JsonElement> tasks = new List<JsonElement>();

            // Serializacja profilu z dodaną listą "tasks"
            var updatedProfile = new Dictionary<string, object>(profile.GetType().GetProperties()
                .ToDictionary(p => p.Name, p => p.GetValue(profile)));

            updatedProfile["tasks"] = tasks;

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            // Serializacja zaktualizowanego profilu
            string jsonString = JsonSerializer.Serialize(updatedProfile, options);
            File.WriteAllText(filePath, jsonString);
        }


        /// <summary>
        /// Lista wszystkich profili, czyli plików z roszrzerzeniem .json
        /// </summary>

        public static List<string> ListOfAllProfiles = new List<string>();


        /// <summary>
        /// Pobieranie wszystkich plików z rozszerzeniem .json i ułozenie ich do listy ListOfAllProfiles
        /// </summary>
        /// <param name="cb">ComboBox z nazwami wszystkich profili - ten, co jest na formularzu form</param>

        public static void LoadAllProfilesFromFile(ComboBox cb)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string crudaFolderPath = Path.Combine(appDataPath, Base_SemestrProfile.NameOfAppDataFolder);

            if (!Directory.Exists(crudaFolderPath))
                throw new ArgumentException("Żaden profil nie został nigdy stworzony!", "CRUDADirectoryDoesNotExist");

            else
            {
                ListOfAllProfiles = Directory.GetFiles(crudaFolderPath, "*.json").ToList<string>();

                if (ListOfAllProfiles.Count <= 0)
                    throw new ArgumentException("Brak profili w systemie!", "NoProfilesFound");


                else if (ListOfAllProfiles.Count > 0)
                    foreach (string profileName in ListOfAllProfiles)
                        cb.Items.Add(Path.GetFileName(profileName.Remove(profileName.Length - 5)));
            }
        }


        /// <summary>
        /// Metoda pobierająca listę przedmiotów z pliku .json
        /// </summary>

        static public List<string> LoadListOfSubjectFromFile()
        {
            string filePath = Path.Combine(CrudaFolderPath, Base_AppState.ChosenProfile + ".json");

            if (!File.Exists(filePath))
                throw new FileNotFoundException("Nie znaleziono pliku profilu!", filePath);

            string jsonString = File.ReadAllText(filePath);

            using (JsonDocument doc = JsonDocument.Parse(jsonString))
            {
                JsonElement root = doc.RootElement;

                if (root.TryGetProperty("listOfSubjects", out JsonElement subjectsElement) &&
                    subjectsElement.ValueKind == JsonValueKind.Array)
                {
                    List<string> subjects = new List<string>();

                    foreach (JsonElement item in subjectsElement.EnumerateArray())
                        subjects.Add(item.GetString());

                    return subjects;
                }
                else
                    throw new ArgumentException("Nie znaleziono listy przedmiotów w pliku JSON.", "ListOfSubjectsNotFound");
            }
        }
    }
}
