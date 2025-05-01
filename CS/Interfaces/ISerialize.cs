using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Interfaces
{
    interface ISerialize
    {

        /// <summary>
        /// Zapisywanie danych związanych z zadaniami i profilem do pliku .json 
        /// </summary>

        public void SaveDataToFile();

        public void LoadDataFromFile();


    }
}
