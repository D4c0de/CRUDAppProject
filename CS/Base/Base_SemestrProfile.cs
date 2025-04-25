using CRUDAppProject.CS.Interfaces;
using CRUDAppProject.CS.Static;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
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
        /// Otwiera okno tworzenia nowego przedmiotu 
        /// </summary>
        
        static public void AddSubject()
        {

        }


        /// <summary>
        /// Otwiera okno usuwania istniejącego przedmiotu z listy przedmiotów
        /// </summary>
        
        static public void RemoveSubject()
        {
            
        }


        /// <summary>
        /// Otwiera okno tworzenia nowego profilu
        /// </summary>
        
        static public void CreateProfile()
        {
            


        }


        /// <summary>
        /// Otwiera okno edytowania istniejącego profilu
        /// </summary>
        
        static public void EditProfile()
        {

        }

        
        /// <summary>
        /// Otwiera okno usuwania istniejącego profilu
        /// </summary>
        
        static public void DeleteProfile()
        {

        }


        /// <summary>
        /// Otwiera okno wyboru istniejącego profilu
        /// </summary>
        
        static public void ChooseProfile()
        {

        }


        /// <summary>
        /// Edytuje istniejący już przedmiot
        /// </summary>
        /// <param name="s">Nazwa przedmiotu, który należy usunąć z listy przedmiotów</param>
        
        static public void EditSubject(string s)
        {
            
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

            
            if (this.ListOfSubjects.Count == 0)
                throw new ArgumentException("Lista jest pusta. Nie można zapisać.");

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            
            Type itemType = this.ListOfSubjects[0].GetType();

            
            string jsonString = JsonSerializer.Serialize(this.ListOfSubjects, typeof(List<>).MakeGenericType(itemType), options);

            
            string filePath = Path.Combine(crudaFolderPath, this.Name + ".json");
            File.WriteAllText(filePath, jsonString);
        }


        /// <summary>
        /// Pobiera dane związane z profilem z pliku .json
        /// </summary>

        public void LoadDatFromFile()
        {

        }
    }
}
