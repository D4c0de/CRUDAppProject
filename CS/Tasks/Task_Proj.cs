using CRUDAppProject.CS.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Tasks
{

    /// <summary>
    /// Klasa dziedzicząca po klasie abstrakcyjnej Base_Task - określa zadania z kategorii Projekty
    /// </summary>

    internal class Task_Proj : Base_Task
    {
        
        /// <summary>
        /// Lista uczestników projektu
        /// </summary>

        private List<string> _members;
        public List<string> Members
        {
            get { return this._members; }
            set { this._members = value; }
        }


        /// <summary>
        /// Pozwala dodanie uczestnika projektu do listy uczestników
        /// </summary>
        static public void AddMember()
        {

        }


        /// <summary>
        /// Pozwala usunąć uczestnika projektu z listy uczestników
        /// </summary>
        static public void RemoveMember()
        {

        }

    }
}
