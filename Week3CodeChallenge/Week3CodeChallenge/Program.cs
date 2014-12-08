using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FindPrimes
            FindNPrimes(1001);
            #endregion
            #region EvenFibonacciSequencer
            EvenFibonacciSequencer(20);
            #endregion
            #region LongestCollatzSequence
            LongestCollatzSequence();
            #endregion
            Console.ReadKey();
        }

        #region FindNPrimes
        static void FindNPrimes(int maxPrime)
        {
            int start = 2;
            int primes = 0;
            //loop  while maxprimes is not met
            while (maxPrime > primes)
            {
                if (checkPrime(start))
                {
                    primes++;
                }
                start++;
            }
            Console.WriteLine("there are {0} primes for a maxPrime of {1}", start, maxPrime);
        }
        static bool checkPrime(int val)
        {
            int floor = 2;
            bool prime = true;
            for (int i = floor; i < val; i++)
            {
                if (val % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
        #endregion
        #region EvenFibonacciSequencer
        static void EvenFibonacciSequencer(int maxValue)
        {
            //all fibonacci sequences will start with 1 and 2
            int seed = 1; int seed2 = 2; int prevFib = 0; int currentFib = 0; int nextFib = 0; int startCheck = 1;
            prevFib = seed; currentFib = seed2;
            List<int> Evens = new List<int>();
            for (int i = 2; i < maxValue; i++) //add the values of all even Fibonacci number up to the maxValue
            {
                if (startCheck == 0) // use seed to start fib
                {
                    nextFib = prevFib + currentFib;
                    if (isEven(currentFib)) //check if number is even
                    {
                        Evens.Add(currentFib); //add it to list
                    }
                }
                else  //generate next fib beyond seed
                {
                    nextFib = prevFib + currentFib;
                    prevFib = currentFib;
                    currentFib = nextFib;
                    if (isEven(currentFib))
                    {
                        Evens.Add(currentFib);  //add it to list
                    }
                }
            }
            Console.WriteLine(Evens.Sum()); //write the number to the console
        }

        static bool isEven(int num)
        {
            bool evenFib = false;
            if (num % 2 == 0)
            {
                evenFib = true;
            };
            return evenFib;
        }
        #endregion
        #region LongestCollatzSequence
        static void LongestCollatzSequence()
        {
            long collatzLength = 0;
            long start = 0;
            long collatz;
            for (int i = 2; i < 1000000; i++)
            {
                int length = 1;
                collatz = i;
                while (collatz != 1)
                {
                    if ((collatz % 2) == 0) //if collatz is even: divide collatz by 2
                    {
                        collatz = collatz / 2;
                    }
                    else //if collatz is odd: collatz * 3 + 1
                    {
                        collatz = 3 * collatz + 1;
                    }
                    length++;
                }

                //check for better collatz
                if (length > collatzLength)
                {
                    collatzLength = length;
                    start = i;
                }
            }
            Console.WriteLine("{0} had a collatz of {1}", start, collatzLength);
        }
        #endregion
    }
}
