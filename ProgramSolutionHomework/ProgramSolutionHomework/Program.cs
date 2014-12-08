using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Aiko";
            int myAge = 29;
            bool myBool = true;
            List<string> productsList = new List<string> { "basketball", "baseball glove", "tennis shoes", "hockey puck" };

            Console.WriteLine("My name is " + myName + " and I'm a beast of a programmer");
            Console.WriteLine("I am " + myAge + " years awesome.");
            Console.WriteLine("I set my boolean value equal to " + myBool);
            for (int i = 0; i < productsList.Count(); i++)
            {
                string product = productsList[i];
                Console.WriteLine(product);
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i <= 30; i = i + 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 100; i >= 75; i = i - 5)
            {
                Console.WriteLine(i);
            }

            int te = 1;
            while (te <= 10)
            {
                Console.WriteLine(te);
                te++;
            }

            int te2 = 10;
            while (te2 >= 1)
            {
                Console.WriteLine(te2);
                te2--;
            }

            int te3 = 15;
            while (te3 <= 30)
            {
                if (te3 % 2 == 0)
                {
                    Console.WriteLine(te3);
                }
                te3++;
            }

            int te4 = 100;
            while (te4 >= 75)
            {
                Console.WriteLine(te4);
                te4 = te4 - 5;
            }

            int te5 = 1;
            while (te5 <= 10)
            {
                Console.WriteLine(te5);
                if (te5 % 4 == 0)
                {
                    break;
                }
                te5++;
            }

            int te6 = 1;
            while (te6 <= myName.Length)
            {
                Console.WriteLine("My name, " + myName + ", has " + te6 + " in it.");
                te6++;
            }

            Console.WriteLine("My product list has " + productsList.Count() + " products in it.");

            for (int i = 0; i < productsList.Count; i++)
            {
                Console.WriteLine(productsList[i] + " has " + CharCounter(productsList[i]) + " letters in it.");
            }

            Greeting("Geronimo Jackson");
            Greeting(myName);
            DoubleIt(1337);
            DoubleIt(myAge);
            Multiply(2, 8);
            Multiply(3, myAge);
            LoopThis(20, 30);
            LoopThis(0, myAge);
            SuperLoop(0, 100, 15); 
            SuperLoop(0, 200, myAge);
            Console.WriteLine(NewGreeting("Neil deGrasse-Tyson"));
            Console.WriteLine(NewGreeting(myName));
            Console.WriteLine("10 tripled is " + TripleIt(10));
            Console.WriteLine(myAge+" tripled is " + TripleIt(myAge));
            Console.WriteLine(RealMultiply(5 ,10));
            Console.WriteLine(RealMultiply(2, myAge));
            SuperLoop(RealMultiply(1,5),TripleIt(myAge),TripleIt(myAge-3));
            SuperLoop(RealMultiply(1,TripleIt(3)), TripleIt(RealMultiply(myAge,7)), TripleIt(myAge-RealMultiply(2,4)));
            Console.ReadKey();
        }
        #region
        static void Greeting(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static void DoubleIt(int number)
        {
            int Twice = number * 2;
            Console.WriteLine(number + " doubled is " + Twice);
        }

        static void LoopThis(int startNum, int endNum)
        {
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum + ".");
            for (int i = startNum; i < endNum; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void SuperLoop(int startNum, int endNum, int increment) 
        {
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum + ", incrementing " + increment + " each time");
            int loopCount = 0;
            for (int i = startNum; i < endNum; i = i + increment)
            {
                Console.WriteLine(i);
                loopCount++;
            }
            Console.WriteLine("That loop was craaaaaazy, we looped " + loopCount +" times");
        }
        
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 + " times " + num2 + " is " + num1 * num2);
        }
        

        static string NewGreeting(string name)
        {
            return "Hello, " + name;            
        }

        static int TripleIt(int number)
        {
            return number * 3;
        }
#endregion

        static int RealMultiply(int num1, int num2)
        {
            return num1 * num2;
        }


        static int CharCounter(string theWord)
        {
            return theWord.Length;

        }

        //START -- FUNCTION DECLARATIONS 

        //Example function declaration
        static void MyFunction(string myParameter)
        {
            //Code block
        }

        //END   -- FUNCTION DECLARATIONS
    }
}