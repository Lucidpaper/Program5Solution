using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            sumGen("45734");
            sumGen("31337");
            Console.ReadKey();
        }

        
        static void sumGen(string rootThis)
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < rootThis.Length; i++)
            {
				nums.Add(int.Parse(rootThis[i].ToString()));
            }
            while (rootThis.Length >= 1)
            {
				if (rootThis.Length == 1) {
					Console.WriteLine(rootThis);
                    nums.Clear();
                    return;
                }
                else {
                    sumGen(rootThis = nums.Sum().ToString());
                    return;
                }
            }
            return;
        }

        //static void digitalRoot(string rootThis)
        //{
            
        //    int rootVal = 0;
        //    while (rootThis.Length >2)
        //    {
        //        for (int i = rootThis.Length; i > rootThis.Length; i--)
        //        {
        //            rootVal = rootThis[i] + rootVal;
        //        }
        //        rootThis = rootVal.ToString();
        //        Console.WriteLine(rootVal);
        //    }
        //}
    }
}
