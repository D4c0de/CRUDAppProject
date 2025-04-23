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

    internal class Task_Exam
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



    }
}
