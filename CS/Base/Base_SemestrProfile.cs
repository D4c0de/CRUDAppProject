using CRUDAppProject.CS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            set { this._name = value; }
        }


        /// <summary>
        /// Lista wszystkich przedmiotów, jakie dany profil zawiera
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
        /// Zapisuje dane związane z profilem do pliku .json  
        /// </summary>

        public void SaveDataToFile()
        {

        }


        /// <summary>
        /// Pobiera dane związane z profilem z pliku .json
        /// </summary>

        public void LoadDatFromFile()
        {

        }
    }
}
