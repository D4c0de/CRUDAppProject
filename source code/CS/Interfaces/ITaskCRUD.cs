using CRUDAppProject.CS.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Interfaces
{

    /// <summary>
    /// Metody które należy zaimplementować do klasy która dziedziczy po klasie abstrakcyjnej Base_Task
    /// </summary>

    interface ITaskCRUD
    {
        /// <summary>
        /// Tworzenie tasków
        /// </summary>

        void CreateTask();


        /// <summary>
        /// Wyświetlanie tasków
        /// </summary>

        void DisplayTask();

        /// <summary>
        /// Usuwanie tasków
        /// </summary>

        void RemoveTask();        

    }
}
