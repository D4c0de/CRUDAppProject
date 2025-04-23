using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Base
{
    internal class Base_SemestrProfile
    {
        /// <summary>
        /// Nazwa profilu z zapisanymi przedmiotami  i zadaniami, którym zarządza użytkownik
        /// </summary>

        private string _name;
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Lista wszystkich przedmiotów, jakie dany profil zawiera
        /// </summary>

        private List<string> _listOfSubjects;
        public List<string> ListOfSubjects
        {
            get { return this._listOfSubjects; }
            set { this._listOfSubjects = value; }            
        }



    }
}
