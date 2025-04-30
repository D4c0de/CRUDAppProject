using CRUDAppProject.CS.Interfaces;
using CRUDAppProject.CS.Static;
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


        /// <summary>
        /// Zapisywanie danych związanych z profilem i listą przedmiotów do pliku .json 
        /// </summary>

        public void SaveDataToFile()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string crudaFolderPath = Path.Combine(appDataPath, NameOfAppDataFolder);


            if (!Directory.Exists(crudaFolderPath))
            {
                Directory.CreateDirectory(crudaFolderPath);
            }

            string filePath = Path.Combine(crudaFolderPath, this.Name + ".json");

            // Wyrzuć wyjątke, jeżeli nazwa pliku jest pusta

            if (string.IsNullOrWhiteSpace(this.Name) || string.IsNullOrEmpty(this.Name))
                throw new ArgumentException("Profil nie ma żadnej nazwy!", "NullOrEmptyFileName");


            // Wyrzuć wyjątek, jeśli plik o danej nazwie już istnieje

            if (File.Exists(filePath))
                throw new ArgumentException("Profil istnieje!", "FileAlreadyExists");

            // Wyrzuć wyjątek, jeśli lista przedmiotów jest pusta

            if (!(this.ListOfSubjects.Count > 0))
                throw new ArgumentException("Lista przedmiotów jest pusta!", "EmptyListOfSubjects");

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            Type itemType = this.ListOfSubjects[0].GetType();

            string jsonString = JsonSerializer.Serialize(this.ListOfSubjects, typeof(List<>).MakeGenericType(itemType), options);

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
                {
                    foreach (string profileName in ListOfAllProfiles)
                    {
                        cb.Items.Add(Path.GetFileName(profileName.Remove(profileName.Length - 5)));
                    }
                }
            }
        }



        /// <summary>
        /// Pobiera dane związane z profilem z pliku .json
        /// </summary>

        public void LoadDatFromFile()
        {

        }

    }
}
