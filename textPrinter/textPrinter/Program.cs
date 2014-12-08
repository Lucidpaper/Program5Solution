using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textPrinter
{
    class Program
    {
        static void Main()
        {
            linePrinter(4, 1, "asdfasdfasd asdfasdf asdfasdf");
            linePrinter(12, 20, "sam i love you");

        }

        static void textPrinter(int timeOfPause, string printString)
        {
            int textPosition = 0;
            for (int i = 0; i < printString.Length; i++)
            {
                Console.Write(printString[i]);
                System.Threading.Thread.Sleep(timeOfPause);
                textPosition++;
            }

        }

        static void linePrinter(int lineNumber, int LPtimeOfPause, string LPprintString)
        {
            int linePostion = 0;
            for (int i = 0; i < lineNumber; i++)
            {
                textPrinter(LPtimeOfPause,LPprintString);
                Console.WriteLine("\n");
                linePostion++;
            }
        }
    }
}
