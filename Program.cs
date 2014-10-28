using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Console.ReadKey();
        }

        /// <summary>
        /// Writes hello word to the console
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello world");
            
            int myAgeDoubled = DoubleIt(29);
            Console.WriteLine(
                DoubleIt(
                myAgeDoubled
                )
            );
            //LoopTests();
            vowelConterTest3000Test();
        }

        /// <summary>
        /// returns a number after doubling it
        /// </summary>
        /// <param name="someNumber">Number to be doubled</param>
        /// <returns>someNumber doubled</returns>
        static int DoubleIt(int someNumber)
        {
            return someNumber * 2;
        }

        /// <summary>
        /// Prints numbers to console
        /// </summary>
        /// <param name="startNumber">starting number of the loop</param>
        /// <param name="endNumber">inclusive ending number of the loop</param>
        static void LoopSomeNumbers(int startNumber, int endNumber) 
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// run a set of test on loopSomeNumber Function
        /// </summary>
        static void LoopTests()
        {
            LoopSomeNumbers(5,10);
            Console.ReadKey();
            LoopSomeNumbers(234, 567);
            LoopSomeNumbers(31, DoubleIt(23));
        }

        /// <summary>
        /// returns number of strings in a string
        /// </summary>
        /// <param name="inputString">a string that your want to count number of vowels</param>
        /// <returns>the number of vowels found</returns>
        static int VowelCounter3000(string inputString)
        {
            //declare a counter for the vowels
            int numberOfVowelsFound = 0;
            
            //loop over each letter of the string
            for (int i = 0; i < inputString.Length; i++)
            {
                //take a letter from the string and make it lower case
                string letter = inputString[i].ToString().ToLower();
                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
                {
                    //found a vowel 
                    numberOfVowelsFound = numberOfVowelsFound + 1;
                }
               
            }

            Console.WriteLine(inputString + " has " + numberOfVowelsFound + " vowels");
            return numberOfVowelsFound;
        }

        static void vowelConterTest3000Test()
        {
            int totalNuberOfVowelsCounted = 0;
            totalNuberOfVowelsCounted += VowelCounter3000("asdfasdfasdfasdfasdf");
            totalNuberOfVowelsCounted += VowelCounter3000("asdfasdaaaafasdfasdfasdf");
            Console.WriteLine(totalNuberOfVowelsCounted);
        }

    }
}
