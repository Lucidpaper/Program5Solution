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
            #region fizzbuzz
            //for (int i = 0; i <= 20; i++) { fizzBuzz(i); }
            //Console.ReadKey();

            //fizzBuzz(7, 27);
            //Console.ReadKey();

            //for (int n = 92; n >= 72; n--) { fizzBuzz(n); }
            //Console.ReadKey();
            #endregion
            #region Yodaizer
            yodaizer("I like code");
            Console.ReadKey();
            #endregion
            #region TextStats
            textStats("In a new study, Yvon Le Maho of the University of Strasbourg in France and colleagues equipped thirty four king penguins with an external heart rate monitor. that could be read with an RFID antenna A day later they sent an unadorned four-wheeled rover into the colony. Not only did the penguins let the rover get close enough to read their monitors, the birds heart rates increased less and returned to normal more quickly than when the same task was done by a human with a handheld reader.");
            Console.ReadKey();
            #endregion
            #region isPrime
            for (int i = 0; i <= 25; i++)
            {
                if (i % 2 != 0)
                {
                    isPrime(i);
                }
            }
            #endregion
            #region DashInsert
            dashInsert(8675309);
            Console.ReadKey();
            #endregion
        }
        #region completeCode
        #region fizzbuzzCode
        static void fizzBuzz(int number)
        {
            for (int i = 0; i < 1; i++)
            {
                if (number != 0 && number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz | Fi{0}{0}Bu{0}{0}", number);
                    break;
                }
                if (number != 0 && number % 3 == 0)
                {
                    Console.WriteLine("Fizz | Fi{0}{0}", number);
                    break;
                }
                if (number != 0 && number % 5 == 0)
                {
                    Console.WriteLine("Buzz | Bu{0}{0}", number);
                    break;
                }
                if (number % 3 != 0 || number % 5 != 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

        static void fizzBuzz(int number, int number2)
        {
            for (int i = number; i <= number2; i++)
            {
                if (i != 0 && i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz | Fi{0}{0}Bu{0}{0}", i);
                    break;
                }
                if (i != 0 && i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Fizz | Fi{0}{0}", i);
                    break;
                }
                if (i != 0 && i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Buzz | Bu{0}{0}", i);
                    break;
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        #endregion
        #region YodaizerCode
        static void yodaizer(string text)
        {
            string[] words = text.Split();
            Array.Reverse(words);
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < words.Length; i++) { builder.Append(words[i]).Append(" "); } Console.WriteLine(builder);
            if (words.Length == 3) { Console.WriteLine("{2}, {0} {1}", words[2], words[1], words[0]); }
        }
        #endregion
        #region TextStatsCode
        static void textStats(string input)
        {
            Console.WriteLine("input lenght {0}", input.Length);
            Console.WriteLine("words count {0}", input.Split().Length);
            int vowelCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string letter = input[i].ToString();
                if ("aeiou".Contains(letter.ToLower()))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("vowel count {0}", vowelCount);

            int consonantCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string letter = input[i].ToString();
                if ("bcdfghjklmnpqrstvwxyz".Contains(letter.ToLower()))
                {
                    consonantCount++;
                }
            }
            Console.WriteLine("consonant count {0}", consonantCount);

            int specialCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string letter = input[i].ToString();
                if ("'-() _,.?".Contains(letter.ToLower()))
                {
                    specialCount++;
                }
            }
            Console.WriteLine("special count {0}", specialCount);
        }
        #endregion
        #region isPrimeCode
        static void isPrime(int number)
        {
            if (number < 3)
            {
                if (number == 2)
                {
                    Console.WriteLine("{0} is a prime number", number);
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                else
                {
                    int div;
                    for (div = 3; number % div != 0; div += 2)
                        ;

                    if (div == number)
                    {
                        Console.WriteLine("{0} is a prime number", number);
                    }
                    else
                    {
                        Console.WriteLine(number);
                    }
                }
            }

            Console.ReadLine();
        }
        #endregion
        #endregion
        #region dashInsertCode
        static void dashInsert(int number)
        {
            StringBuilder phone = new StringBuilder();
            string val = number.ToString();
            int test = val.ToString().Length;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                if (int.Parse(val[i].ToString()) == 0)
                {
                    phone.Append(val[i]);
                }
                else if (i + 1 >= val.Length)
                {
                    phone.Append(val[i]);
                    break;
                }
                else if (int.Parse(val[i].ToString()) % 2 != 0 && int.Parse(val[i + 1].ToString()) % 2 != 0)
                {
                    phone.Append(val[i]).Append("-");
                }
                else
                {
                    phone.Append(val[i]);
                }

            }
            Console.WriteLine(phone);
        }
        #endregion

    }
}
