using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Static;
using CRUDAppProject.CS.Tasks;
using CRUDAppProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CRUDAppProject
{
    class CRUDAppProject
    {
        static void Main(string[] args)
        {
            
            Form_Logging Screen_Logging = new Form_Logging();
            Screen_Logging.Show();

            Application.Run();                 

        }
    }
}
