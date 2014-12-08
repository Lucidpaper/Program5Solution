using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication2
{
    class Program
    {
        static List<string> lettersGuessed = new List<string>();
        static int numberOfGuesses = 8;
        static string maskString;
        static string userGuess;

        static void Main(string[] args)
        {
            hangMan();
            Console.ReadKey();
        }

        static void hangMan()
        {

            string wordToGuess = hangWord();
            Console.WriteLine("Welcome to Hangman\nWhat is your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("{0} puts on the 13 loop noose\nYou Have {1} guesses", name, numberOfGuesses);
            while (numberOfGuesses > 0)
            {
                do
                {
                    Console.WriteLine("Guess a letter or word:");
                    userGuess = Console.ReadLine();
                } while (checkInput(userGuess));
                checker(userGuess,wordToGuess);
            }

        }

        static void checker(string userInput, string wordToGuess)
        {
            if (userInput.Length > 1)
            {
                if (userInput == wordToGuess)
                {
                    Console.WriteLine("You win the word is {0}", wordToGuess);
                }
                else
                {
                    numberOfGuesses--;
                }
            }
            else
            {
                lettersGuessed.Add(userInput);
                foreach (string guessedLetter in lettersGuessed)
                {
                    maskString = "";
                    foreach (char letter in wordToGuess)
                    {
                        if (letter.ToString().ToLower() == guessedLetter)
                        {
                            maskString += " " + letter + " ";
                        }
                        else
                        {
                            maskString += " _ ";
                        }
                    }
                }
                numberOfGuesses--;
                Console.WriteLine("");
                Console.WriteLine(maskString);
                if (!maskString.Contains('_'))
                {
                    Console.WriteLine("You Win!!!!");

                }
            }
            Console.WriteLine("You have {0} number of guesses left", numberOfGuesses);
        }

        static void maskWord(string wordToGuess)
        {

        }


        static bool checkInput(string userInput)
        {
            return Regex.IsMatch(userInput, @"[\d_]") || Regex.IsMatch(userInput, @"[^\w\s]");
        }

        #region hangword
        static string hangWord()
        {
            Random rng = new Random();
            string inputString = "One cool autumnal night, while lying by his camp-fire in the woods," + 
            " he observed that the mosquitoes flew in the blaze and were burned. Johnny, who wore on his head" +
            " a tin utensil which answered both as a cap and a mush pot, filled it with water and quenched the fire, " +
            "and afterwards remarked, God forbid that I should build a fire for my comfort, that should be the means of destroying any of His creatures.";
            List<string> wordBank = new List<string>(Regex.Replace(inputString, @"[^\w\s]", "").Split());
            string holderString = (wordBank[rng.Next(0, wordBank.Count() - 1)]);
            while (holderString.Length < 4)
            {
                holderString = (wordBank[rng.Next(0, wordBank.Count() - 1)]);
            }
            return holderString;
        }
        static string hangWord(string inputString)
        {
            Random rng = new Random();
            List<string> wordBank = new List<string>(Regex.Replace(inputString, @"[^\w\s]", "").Split());
            string holderString = (wordBank[rng.Next(0, wordBank.Count() - 1)]);
            while (holderString.Length < 4)
            {
                holderString = (wordBank[rng.Next(0, wordBank.Count() - 1)]);
            }
            return holderString;
        }
        #endregion
    }
}
