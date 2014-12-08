using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperSpace
{
    public class Unit
    {
        public int X { get; set; }
        public int y { get; set; }
        public ConsoleColor Color { get; set; }
        public string Symbol { get; set; }
        public bool isSpaceRift { get; set; }

        static List<string> ObstacleList = new List<string>(new string[] { "*", "!", ".", ":" });
        public static Random rng = new Random();

        //constructor from page 61
    }
    
}
