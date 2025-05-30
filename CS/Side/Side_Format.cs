
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Side
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


        /// <summary>
        /// Formatuje tekst tak, aby wszystkie wyrazy ze zdania oddzielone przecinkiem były traktowane jako nowy string i zwraca listę tych stringów (wyrazów)
        /// </summary>
        /// <param name="s">String do sformatowania</param>
        /// <returns>String "ALA, mA, KotA, a, Kot, Ma, Ale, " zwróci jako listę {"Ala", "Ma", "Kota", ... , "Ale"}</returns>

        public static List<string> CutIntoSingleWords(string s)
        {
            List<string> listOfWords = new List<string>();

            string cleaned = Regex.Replace(s, @"\s+", " ");

            string[] parts = cleaned.Split(',');

            foreach (var part in parts)
            {
                string word = part.Trim();

                if (!string.IsNullOrWhiteSpace(word))
                {
                    listOfWords.Add(CapitalizeString(word));
                }
            }

            return listOfWords;
        }

    }
}
