using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CannonAttack
{
    class CannonAttack
    {
        private static readonly int MaxNumberOfShots = 50;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CannonAttack");
            bool isStillPlaying = true;
            while (isStillPlaying)
            {
                bool isAHit = false;
                Cannon cannon = Cannon.GetInstance();
                while (!isAHit && cannon.Shots < MaxNumberOfShots)
                {
                    int angle;
                    int velocity;
                    Console.WriteLine(String.Format("Target is at {0} meters", cannon.DistanceOfTarget));
                    GetInputVariable(out angle, out velocity);
                    var shot = cannon.Shoot(angle, velocity);
                    isAHit = shot.Item1;
                    Console.WriteLine(shot.Item2);
                }
                isStillPlaying = GetIsPlayingAgain();
                cannon.Reset();
            }
            Console.WriteLine("Thanks for playing Cannon Attack");
        }
    }
}
