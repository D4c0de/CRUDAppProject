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
        /// Zapisywanie danych związanych z zadaniami i profilem do pliku .json 
        /// </summary>

        public void SaveDataToFile();


        /// <summary>
        /// Pobranie danych związanych z zadaniami i profilem z pliku .json
        /// </summary>

        public void LoadDatFromFile();
        

    }
}
