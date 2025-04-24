using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Static;
using CRUDAppProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject
{
    class CRUDAppProject
    {
        public Base_SemestrProfile Profile = new Base_SemestrProfile();
        

        static void Main(string[] args)
        {
            Form_Logging Screen_Logging = new Form_Logging();
            Screen_Logging.Show();

            Application.Run();

        }
    }

}
