using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Base
{
    /// <summary>
    /// Klasa przechowująca bieżące informacje niezbędne do obsługi logiki logowania i przechowywania danych
    /// </summary>

    class Base_AppState
    {
        /// <summary>
        /// Nazwa profilu, na który użytkownik się zalogował
        /// </summary>

        static private string _chosenProfile;
        static public string ChosenProfile
        {
            set { _chosenProfile = value; }
            get { return _chosenProfile; }
        }

    }
}
