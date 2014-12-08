using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2CodeChallenge
{
    class Program
    {
        static void Main()
        {
            FizzBuzz(20);
            letterCounter('i', "I love biscuits and gravy. It's the the best breakfast ever.");
            letterCounter('n', "Never gonna give you up. Never gonna let you down.");
            letterCounter('s', "Sally sells seashells down by the seashore. She is from Sussex.");
            Console.Read();
        }

        static void FizzBuzz(int number)
        {
            for (int i = 0; i < number + 1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i != 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void letterCounter(char letter, string inString)
        {
            int upper = 0;
            int lower = 0;
            int count = 0;
            for (int i = 0; i < inString.Length; i++)
            {
                count++;
                if (char.IsUpper(inString[i]))
                {
                    upper++;
                }
                if (char.IsLower(inString[i])) 
                {
                    lower++;
                }
            }
            Console.WriteLine
                (
                @"input: {0}
                Number of lowercase {1}'s found: {2}
                Number of UPPERCASE {3}'s: {4}
                Total number of {5}'s: {6}
                "  
                , inString, letter, lower ,letter , upper ,letter , count
                );
        }
    }
}
