using CRUDAppProject.CS.Interfaces;
using CRUDAppProject.CS.Side;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Base
{

    /// <summary>
    /// Klasa abstrakcyjna która jest podstawą do klas związanych z rodzajami zadań
    /// </summary>

    public abstract class Base_Task
    {
        /// <summary>
        /// Nazwa zadania
        /// </summary>

        protected string _title;
        public string Title
        {
            get { return this._title; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value) && !string.IsNullOrEmpty(value))
                {
                    value = value.Trim();
                    this._title = Side_Format.CapitalizeString(value);
                }

                else
                    throw new ArgumentException("Nazwa zadania nie może być pusta!", "TaskTitleNullOrEmpty");

            }
        }


        /// <summary>
        /// Opis zadania
        /// </summary>

        protected string _description;
        public string Description
        {
            get { return this._description; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value) && !string.IsNullOrEmpty(value))
                {
                    value = value.Trim();
                    this._description = value;
                }

                else
                    throw new ArgumentException("Opis zadania nie może być pusty!", "TaskDescriptionNullOrEmpty");

            }
        }

        private string _chosenSubject;
        public string ChosenSubject
        {
            get { return this._chosenSubject; }
            set
            {
                if (Base_AppState.ChosenProfileSubjects.Contains(Side_Format.CapitalizeString(value)))
                {
                    this._chosenSubject = value;
                }

                else
                    throw new ArgumentException("Wybrany przedmiot nie istnieje w liście zapisanych przedmiotów dla danego profilu!", "SubjectNotFound");
            }
        }


        /// <summary>
        /// Termin ostateczny oddania zadania
        /// </summary>

        protected DateTime _deadline;
        public DateTime Deadline
        {
            get { return this._deadline; }
            set 
            { 
                this._deadline = value; 
            }
        }


        /// <summary>
        /// Czy zadanie zostało wykonane 
        /// </summary>

        protected bool _isCompleted = false;
        public bool IsCompleted
        {
            get { return this._isCompleted; }
            set { this._isCompleted = value; }
        }


        /// <summary>
        /// Data utworzenia zadania
        /// </summary>

        protected DateTime _dateOfCreation;
        public DateTime DateOfCreation
        {
            get { return this._dateOfCreation; }
            set { this._dateOfCreation = DateTime.Now.Date; }
        }

        private string _shortDescription;
        public string ShortDescription
        {
            get { return this._shortDescription; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value) && value.Length > 0 && value.Length <= 32)
                {
                    this._shortDescription = value;
                }

                else if (value.Length > 32)
                    throw new ArgumentException("Opis jest za długi! Maksymalnie 32 znaki!", "ShortDescriptionTooLong");

                else if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Opis nie może być pusty!", "EmptyShortDescription");

            }
        }

        /// <summary>
        /// Krotka przechowująca stan zadania
        /// </summary>

        public (string TODO, string InProgress, string Done) TupleOfStatuses = ("Do zrobienia", "W trakcie", "Gotowe");

        
        /// <summary>
        /// Stan zadania
        /// </summary>

        protected string _status = ("Do zrobienia", "W trakcie", "Gotowe").Item1;
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        public static int CardLength = 1150;
        public static int CardWidth = 100;
        public static int SpaceBetweenCardsOnY
        {
            get { return Base_AppState.CardCount * 110;}
            set { }
        }



        // Lista rodzajów zadań 

        public static List<string> ListOfTaskTypes = new List<string>() { "Ćwiczenie", "Projekt", "Egzamin" };


        public abstract void TaskCreator();

        public abstract void TaskDisplayer();

        public abstract void TaskEditor();

        public abstract void TaskRemover();

        public abstract void ShowTaskCard(Panel panelToShowOn);
    }
}
