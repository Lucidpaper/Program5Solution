using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipMania(1000);
            FlipForHeads(1000);
            Console.ReadLine();
        }

        static void FlipMania(int numberOfFilps)
        {
            int numberOfHeads = 0, numberOfTails = 0;
            Random rng = new Random();
            rng.Next(0, 2) == 0 ? numberOfHeads++ : numberOfTails++;

            Console.WriteLine("We flipped a coin {0} times.", numberOfFilps);
            Console.WriteLine("Number Of Heads: {0}", numberOfHeads);
            Console.WriteLine("Number Of Tails: {0}", numberOfTails);
        }

        static void FlipForHeads(int numberOfHeads)
        {
            int numberOfHeadsFlipped = 0;
            int totalFlips = 0;
            Random rng = new Random();
            while (numberOfHeadsFlipped <= numberOfHeads)
            {
                totalFlips++;
                if (rng.Next(0,2) == 0)
                {
                    numberOfHeadsFlipped++;                    
                }
            }
            Console.WriteLine("We are flipping a coin until we find " + numberOfHeads + " heads");
            Console.WriteLine("it took " + totalFlips + " to find " + numberOfHeads + " heads");

        }
    }
}
