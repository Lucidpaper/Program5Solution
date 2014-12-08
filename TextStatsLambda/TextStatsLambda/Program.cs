using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            TextStats("blue cows hate busy work. orange cows request engaging work. the real cow is fake.");
            Console.ReadKey();
        }

        static void TextStats(string input)
        {
            Console.WriteLine(@"
    Number of Characters: {0}
    Number of words: {1}
    Number of vowels: {2}
    Number of consonants: {3}
    Number of special characters: {4}
    Longest Word: {5}
    Shortest Word: {6}
    ", input.Length, 
    input.Split().Length, 
    input.Where(x => "aeiou".Contains(x)).Count(),
    input.Where(x => x == 'b' || x == 'c' || x == 'd' || x == 'f' || x == 'g' || x == 'h' || x == 'j' || x == 'k' || x == 'l' || x == 'm' || x == 'n' || x == 'p' || x == 'q' || x == 'r' || x == 's' || x == 't' || x == 'v' || x == 'w' || x == 'x' || x == 'y' || x == 'z').Count(),
    input.Where(x => !char.IsLetter(x) && !char.IsNumber(x)).Count(),
    input.Split(' ').OrderByDescending(x => x.Length).First(), 
    input.Split(' ').OrderByDescending(x => x.Length).Last());
            



        }
    }
}
