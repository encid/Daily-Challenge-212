using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge212
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Rovarspraket("Jag talar Rövarspråket!"));

            Console.ReadKey();
        }

        static string Rovarspraket(string input)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string output = "";

            foreach (var c in input) {
                if (!vowels.Contains(c) && char.IsLetter(c))
                    output += string.Format("{0}o{0}", c);                
                else output += c;
            }

            return output;
        }
    }
}
