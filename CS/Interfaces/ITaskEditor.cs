using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Interfaces
{
    interface ITaskEditor
    {

        /// <summary>
        /// Edytowanie zadania pod kątem konkretnych parametrów typu nazwa, termin końcowy itd
        /// </summary>
        /// <param name="t">Zadanie spod określonej klasy, które ma zostać edytowane</param>
        
        void EditTask(object t);


        /// <summary>
        /// Uruchomienie edytora zadań
        /// </summary>
        
        void EditTask();


    }
}
