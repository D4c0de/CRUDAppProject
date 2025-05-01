using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Interfaces;
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

    internal class Task_Proj : Base_Task, ITaskCRUD, ISerialize
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
        public override void TaskCreator()
        {

        }

        public override void TaskDisplayer()
        {

        }

        public override void TaskEditor()
        {

        }

        public override void TaskRemover()
        {

        }

        public void CreateTask(Base_Task task)
        {

        }

        public void DisplayTask(Base_Task task)
        {

        }

        public void EditTask(Base_Task task)
        {

        }

        public void RemoveTask(Base_Task task)
        {

        }

        public void SaveDataToFile()
        {

        }
        public void LoadDataFromFile()
        {

        }
    }
}
