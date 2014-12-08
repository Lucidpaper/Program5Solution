using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            guessThatNumber();
            Console.ReadKey();
        }

        static void guessThatNumber()
        {
            Random rng = new Random();
            int guessCount = 0;
            int goal = rng.Next(0,101);
            bool win = false;
            do
            {
                Console.WriteLine("guess a Number between 1 and 100:");
                string value = Console.ReadLine();
                int valueNum = Convert.ToInt32(value);
                if (valueNum == goal)
                {
                    guessCount++;
                    Console.WriteLine("you guessed right!!! it only took {0} tries", guessCount);
                    win = true;
                }
                else if (valueNum > goal)
                {
                    guessCount++;
                    Console.WriteLine("you guessed to high try again!");
                }
                else
                {
                    guessCount++;
                    Console.WriteLine("you guessed to low try again!");
                }    
            } while (win == false);
        }
    }
}
