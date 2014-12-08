using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Battleship
{
    public class Point
    {
        public enum PointStatus
        {
            Empty, Ship, Hit, Miss
        }

        public int X { get; set; }
        public int y { get; set; }
        public PointStatus PointState { get; set; }

        public Point(int x, int y, PointStatus p) {
            this.X = x;
            this.Y = y;
            this.PointState = Status;
        }
    }
}
