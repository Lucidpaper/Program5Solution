using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperSpace
{
    public static class TearSound
    {
        static void sound()
        {
            for (int i = 0; i < Unit.rng.Next(3, 5); i++)
            {
                Console.Beep((Unit.rng.Next(37, 3200)), (Unit.rng.Next(50, 500)));
            }
        }
    }
}
