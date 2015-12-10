using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace wpf
{
    public static class teht1bBL
    {
        public static string calculateLetters(string text)
        {
            text = Regex.Replace(text, "[^a-zäö]", string.Empty);


            char[] array = text.ToCharArray();
            Dictionary<char, int> dikki = new Dictionary<char, int>();
            foreach (char c in array)
            {
                if (dikki.ContainsKey(c))
                {
                    dikki[c]++;
                }
                else
                {
                    dikki.Add(c, 1);
                }
            }
            string result = "";
            foreach (var item in dikki)
            {
                result += item.Key + " = " + item.Value + "\n";
            }
            result += "Merkkejä yhteensä: " + text.Length.ToString() + " Erilaisia kirjaimia: " + dikki.Count().ToString();
            return result;
        }
    }
}
