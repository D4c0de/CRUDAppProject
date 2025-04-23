using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Interfaces
{
    interface ITaskLauncher
    {

        /// <summary>
        /// Wyświetlenie pełnej zawartości zadania typu termin końcowy, skład grupy projektowej itd
        /// </summary>
        /// <param name="t">Zadanie spod określonej klasy, które ma zostać wyświetlone</param>

        void DisplayTask(object t);


        /// <summary>
        /// Wyświetlenie szczegółów dotyczących zadania w pełnym oknie
        /// </summary>
        void DisplayTask();


    }
}
