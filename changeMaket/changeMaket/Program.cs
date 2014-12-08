using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changeMaket
{
    class Program
    {
        static void Main()
        {
            changeMaker(3.18);
            changeMaker(0.99);
            //changeMaker(12.93);
            Console.ReadKey();
        }

        static void changeMaker(double amount)
        {
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;
            Console.WriteLine("Amount: ${0}", amount);
            while (amount >= 0.25)
            {
                quarters++;
                amount -= 0.25;
            }
            while (amount >= 0.10)
            {
                dimes++;
                amount -= 0.10;
            }
            while (amount >= 0.05)
	        {
                nickels++;
                amount -= 0.05;
	        }
            while (amount >= 0.00)
            {
                pennies++;
                amount -= 0.01;
            }
            Console.WriteLine("Quarters: {0}\nDimes: {1}\nNickels: {2}\nPennies: {3}\n", quarters, dimes, nickels, pennies);
        }
    }
}
