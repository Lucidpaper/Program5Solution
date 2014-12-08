using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CannonAttack
{
    public sealed class Cannon
    {
        private readonly string CANNONID = "Human";
        private string CannonID;
        public string ID
        { 
            get
            {
                return (String.IsNullOrWhiteSpace(CannonID)) ? CANNONID : CannonID;      
            }
            set
            {
                CannonID = value;
            }
        }
        private static Cannon cannonSingletonInstance;
        static readonly object padlock = new object();
        private Cannon()
        {
        }
        public static Cannon GetInstance()
        {
            lock (padlock)
            {
                if (cannonSingletonInstance == null)
                {
                    cannonSingletonInstance = new Cannon();
                }
                return cannonSingletonInstance;
            }
        }
        public static readonly int MAXANGLE = 90;
        public static readonly int MINANGLE = 1;
        private readonly int MAXVELOCITY = 300000000;
        private int distanceOfTarget;
        private readonly double GRAVITY = 9.8;
        public Tuple<bool,string> Shoot(int angle, int velocity)
        {
            if (angle > MAXANGLE || angle < MINANGLE)
            {
                return Tuple.Create(false, "Angle Incorrect");
            }
            return Tuple.Create(true, "Angle OK"); //Not going to do //the calculation just yet
            with:
            string message;
            bool hit;
            int distanceOfShot = CalculateDistanceOfCannonShot(angle, velocity);
            if (distanceOfShot == distanceOfTarget)
            {
                message = "Hit";
                hit = true;
            }
            else
            {
                message = String.Format("Missed cannonball landed at {0} meters", distanceOfShot);
                hit = false;
            }
            return Tuple.Create(hit, message);
        }
        public int CalculateDistanceOfCannonShot(int angle, int velocity)
        {
            int time = 0;
            double height = 0;
            double distance = 0;
            double angleInRadians = (3.1415926536 / 180) * angle;
            while (height >= 0)
            {
                time++;
                distance = velocity * Math.Cos(angleInRadians) * time;
                height = (velocity * Math.Sin(angleInRadians) * time) - (GRAVITY * Math.Pow(time, 2)) / 2;
            }
            return (int)distance;
        }

        public void SetTarget(int distanceOfTarget)
        {
            this.distanceOfTarget = distanceOfTarget;
        }
    }
}
