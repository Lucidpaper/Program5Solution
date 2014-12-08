using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CombatSimulator
{
    class Program
    {

        static Random r = new Random();

        static void Main()
        {
            combateSimulator();
            Console.ReadKey();
        }


        

        static void combateSimulator()
        {
            int starthp = 100;
            int hp = 100;
            int dragonHP = 200;
            int sword = r.Next(20, 35);
            int swordChance = r.Next(1, 100);
            int magic = r.Next(10, 15);
            int heal = r.Next(10, 20);
            int dragonDmg = r.Next(5,15);


            Console.WriteLine("welcome to combate!");
            while (hp >= 0 && dragonHP >= 0)
            {
                Console.WriteLine("select: \n1: Attack with sword \n2: Attack with magic fireball or \n3: heal yourself\n");
                var input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("you swing your mighty sword!!!");
                        dragonHP = dragonHP - (sword * (swordChance <= 70 ? 1 : 0));
                        Console.WriteLine("Dragon hp: {0}", dragonHP);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("you ingnite and launch a fireball");
                        dragonHP = dragonHP - magic;
                        Console.WriteLine("Dragon hp: {0}", dragonHP);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("you heal yourself with a soda");
                        hp = hp + (heal * (hp <= starthp ? 1 : 0));
                        Console.WriteLine("hp: {0}", hp);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("the dragon attacks");
                hp = hp - (dragonDmg * (swordChance <= 80 ? 1 : 0));
                Console.WriteLine("your hp: {0}", hp);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
