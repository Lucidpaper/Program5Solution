using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> funTime = new List<string>() { "Blueberry", "redberry", "rasberry", "boat" };
            Console.WriteLine(string.Join(", ",funTime.OrderByDescending(x => x)));
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", funTime.Where(x => x.Contains("berry"))));
            //Console.WriteLine(string.Join(funTime.Where(x => !x.Contains("berry")).OrderBy( x => x.Length())));
            Console.WriteLine(string.Join(", ", funTime.Where(x => x.Length >= 5)));

            Console.WriteLine("total number lof chars: {0}", funTime.Sum(x => x.Length));

            Console.WriteLine("avg # of chars:{0}", funTime.Average(x => x.Length));

            Console.WriteLine(string.Join("\n", funTime.Select(x => x + " has " + x.Count(y => "aeiou".Contains(y)) + "vowels")));
            Console.ReadKey();
        }
    }
}
