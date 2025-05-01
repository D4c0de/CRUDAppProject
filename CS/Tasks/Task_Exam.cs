using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Interfaces;
using CRUDAppProject.Forms.Logged_in_forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Tasks
{
    /// <summary>
    /// Klasa dziedzicząca po klasie abstrakcyjnej Base_Task - określa zadania z kategorii Egzamin
    /// </summary>

    internal class Task_Exam : Base_Task, ITaskCRUD, ISerialize
    {
        /// <summary>
        /// Lista rzeczy, które należy przyswoić aby zaliczyć egzamin
        /// </summary>

        private List<string> _materialScope;
        public List<string> MaterialScope
        {
            get { return this._materialScope; }
            set { this._materialScope = value; }
        }


        /// <summary>
        /// Pozwala dodać kolejny punkt do listy rzeczy, które należy przyswoić
        /// </summary>

        public static void AddMaterialToScope()
        {

        }


        /// <summary>
        /// Pozwala usunąć punkt z listy rzeczy, które należy przyswoić
        /// </summary>

        public static void RemoveMaterialFromScope()
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
