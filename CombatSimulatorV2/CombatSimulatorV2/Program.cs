using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulatorV2
{
    
    class Program
    {
		static Random rng = new Random();
		public static int starthp = 100;
		public static int sword = rng.Next(20, 35);
		public static int swordChance = rng.Next(1, 100);
		public static int magic = rng.Next(10, 15);
		public static int heal = rng.Next(10, 20);
        public static int dragonbreath = rng.Next(5,15);

		static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine();
			game.GameStartPromt ();
			while (game.hero.IsAlive && game.dragon.IsAlive) 
			{
				game.DoAttack (game.dragon);
				game.DoAttack (game.hero);
			}
			game.GameWinState (game.hero.IsAlive == true ? game.hero.Name.ToString() : game.dragon.Name.ToString());// game input enum
            Console.ReadKey();
        }

    }
}
