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

        /// <summary>
        /// Przedmioty przypisane do profilu, na które użytkownik się zalogował
        /// </summary>
        
        static private List<string> _chosenProfileSubjects;
        static public List<string> ChosenProfileSubjects
        {
            set { _chosenProfileSubjects = value; }
            get { return _chosenProfileSubjects; }
        }


    }
}
