using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Tasks
{
    /// <summary>
    /// Klasa dziedzicząca po klasie abstrakcyjnej Base_Task - określa zadania z kategorii Ćwiczenia
    /// </summary>

    internal class Task_Exercise : Base_Task, ITaskCRUD
    {
        /// <summary>
        /// Określa źródło zadania, np konkretne ćwiczenia z określonego przedziału stron w podręczniku
        /// </summary>

        private string _taskSource;
        public string TaskSource
        {
            get { return this._taskSource; }
            set { this._taskSource = value; }
        }

        public void CreateTask(object t)
        {

        }

        public void DisplayTask(object t)
        {

        }

        public void EditTask(object t)
        {

        }

        public void RemoveTask(object t)
        {

        }
    }
}
