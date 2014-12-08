using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fissbuzz
{
    class Program
    {
       
        static void Main(string[] args)
        {
            for (int i = 1; i <= 30; i++)
            {
                fizzbuzz(i);
            }
            Console.ReadKey();
        }

        static void fizzbuzz(int num1)
        {
            if (num1 % 15 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (num1 % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else if (num1 % 3 == 0)
	        {
		        Console.WriteLine("fizz");
	        }
            else
	        {
                Console.WriteLine(num1);
	        }
        }
    }
}
