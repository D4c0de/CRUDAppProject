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
            /*
             Form_Logging Screen_Logging = new Form_Logging();
            Screen_Logging.Show();

            Application.Run(); 
             */


            string test_text = "ALA, mA, KotA, a, Kot, Ma, Ale, ";
            Console.WriteLine($"{test_text}");
            Console.WriteLine("Po uzyciu funkcji");

            List<string> nl = new List<string>();
            nl = Side_Format.CutIntoSingleWords(test_text);
            foreach(string word in nl)
                Console.WriteLine($"{word}");


        }
    }

}
