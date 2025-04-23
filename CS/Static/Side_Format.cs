// TODO: formatowanie daty na czas europejski - tak myślę, czy nam się w ogóle to przyda? na ten moment niech zostanie deklaracja funkcji, może na przyszłość się to uzupełni

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Static
{

    /// <summary>
    /// Klasa statyczna implementująca metody do formatowania danych
    /// </summary>

    internal static class Side_Format
    {
        /// <summary>
        /// "Ucina" znaki z początku i końca, nastepnie formatuje tekst w stringu na taki, aby rozpoczynał się od wielkiej litery a kończył małą literą  
        /// </summary>
        /// <param name="s">String do sformatowania</param>
        /// <returns>Sformatowany string, np.: "  fOO123  " zwróci "Foo123"</returns>

        public static string CapitalizeString(string s)
        {           
            StringBuilder sb = new StringBuilder();

            s = s.Trim();

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                    sb.Append(char.ToUpper(s[i]));

                else if (i > 0)
                    sb.Append(char.ToLower(s[i]));
            }

            return sb.ToString();
        }

    }
}
