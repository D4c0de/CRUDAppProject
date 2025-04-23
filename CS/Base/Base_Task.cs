// TODO stworzyć aby automatycznie dobierało aktualną datę podczas tworzenia zadania

using System;
using System.Collections.Generic;
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

    internal abstract class Base_Task
    {
        /// <summary>
        /// Nazwa zadania
        /// </summary>

        protected string _title;
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }


        /// <summary>
        /// Opis zadania
        /// </summary>

        protected string _description;
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }


        /// <summary>
        /// Termin ostateczny oddania zadania
        /// </summary>

        protected DateTime _deadline;
        public DateTime Deadline
        {
            get { return this._deadline; }
            set { this._deadline = value; }
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
            set { this._dateOfCreation = value; }
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
    }
}
