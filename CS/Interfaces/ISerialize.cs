using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Interfaces
{
    interface ISerialize
    {
        /// <summary>
        /// Metoda służąca do zapisywania danych związanych z zadaniami i profilem do pliku .json 
        /// </summary>

        void SaveDataToFile();


        /// <summary>
        /// Metoda służąca do pobrania danych związanych z zadaniami i profilem z pliku .json
        /// </summary>

        void LoadDatFromFile();




    }
}
