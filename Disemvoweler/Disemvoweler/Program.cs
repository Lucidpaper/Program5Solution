using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            disemvoweler("Nickleback is my favorite band. Their songwriting can't be bear!");
            disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls");
            Console.ReadKey();
        }

        static void disemvoweler(string disMe)
        {
            StringBuilder disemvoweled = new StringBuilder();
            StringBuilder disemvoweledVowels = new StringBuilder();
            string originalText = disMe;
            string vowel = "aeiou";
            for (int i = 0; i < disMe.Length; i++)
            {
                string letter = disMe[i].ToString();
                if (letter.Contains(" ")||letter.Contains(",")||letter.Contains("'")||letter.Contains(".")||letter.Contains("?")||letter.Contains("!"))
                {
                    
                }
                else if (vowel.Contains(letter))
                {
                    disemvoweled.Append(disMe[i]);
                }
                else
	            {
                    disemvoweledVowels.Append(disMe[i]);                        
	            }
            }
            Console.WriteLine("Original: {0}\nDisemvoweled: {1}\nDisemvoweled Vowels: {2}\n", originalText, disemvoweled, disemvoweledVowels);
        }
    }
}
