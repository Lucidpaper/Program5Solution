using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lengthOfStringPlusCountWordInString
{
    class Program
    {
        static void Main(string[] args)
        {
            letterfinder("asdfasdfad lasdf", "a");
            Console.ReadKey();

        }

        static void letterfinder(string thewords, string theletter)
        {
            int wordLength = thewords.Length;
            int counting = 0;
            for (int i = 0; i < wordLength; i++)
            {
                if (thewords[i].ToString().ToLower() == theletter.ToLower())
                {
                    counting++;
                }
            }
            Console.WriteLine(thewords + " has " + theletter + " " + counting + " times.");
        }
    }
}
