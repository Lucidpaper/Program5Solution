using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", 
                "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};


            Console.WriteLine(string.Join(", ", products.OrderBy(x => x)));
            Console.WriteLine();

            var kayakProducts = string.Join(", ", products.Where(x => x.Contains("Kayak"))); //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            Console.WriteLine(kayakProducts); //print the kayakProducts to the console using a foreach loop.


            var shoeProducts = string.Join(", ", products.Where(x => x.Contains("Shoes")));//declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            Console.WriteLine(shoeProducts); //print the shoeProducts to the console using a foreach loop or string.Join().

            var ballProducts = string.Join(", ", products.Where(x => x.Contains("ball")));//declare a variable ballProducts and set it equal to all the products that have ball in the name.
            Console.WriteLine(shoeProducts);//print the ballProducts to the console using a foreach loop or string.Join().

            //sort ballProducts alphabetically and print them to the console.
            Console.WriteLine(string.Join(", ", ballProducts.OrderBy(x => x)));

            //add six more items to the products list using .add().
            products.Add("bow");
            products.Add("arrow");
            products.Add("lax stick");
            products.Add("shuffle board");
            products.Add("bat");
            products.Add("car");

            //print the product with the longest name to the console using the .First() extension.
            Console.WriteLine(products.OrderBy(x => x.Length).First());

            //print the product with the shortest name to the console using the .First() extension.
            Console.WriteLine(products.OrderBy(x => x.Length).Last());

            //print the product with the 4th shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            Console.WriteLine(products.OrderBy(x => x.Length).First());

            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            //http://stackoverflow.com/questions/4174701/lambda-expression-for-getting-indexes-of-list-items-conditionally

            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).
            //print out the reversedProducts to the console using a foreach loop.
            Console.WriteLine(string.Join(", ", ballProducts.OrderByDescending(x => x)));

            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //Note: you will not use a variable to store your list
            Console.WriteLine(string.Join(", ", products.OrderByDescending(x => x)));

            Console.ReadKey();
        }
    }
}