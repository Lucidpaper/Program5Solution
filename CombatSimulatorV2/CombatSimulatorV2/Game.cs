using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulatorV2
{
    class Game
    {
        public Player hero; public Enemy dragon;
        public Game()
        {
            this.hero = new Player(100, "aiko");
            this.dragon = new Enemy(200, "malko");
        }
        public void DisplayCombateInfo()
        {
            Console.WriteLine("{0}'s hp is {1} vs. {2}'s hp is {3}", hero.Name, hero.HP, dragon.Name, dragon.HP);
        }
        public void GameStartPromt()
        {
            Console.WriteLine("You are goin to fight a mighty dragon. What is your name?");
            hero.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("{0} be corageious in your fight against the dragon {1}", hero.Name, dragon.Name);
            DisplayCombateInfo();
        }

        public void GameWinState(string winner)
        {
            Console.WriteLine("The winner is {0}", winner);
        }
        public void DoAttack(Character character)
        {
            if (character == hero)
            {
                this.hero.HP = this.hero.HP - (Program.dragonbreath * (Program.swordChance <= 80 ? 1 : 0));
                if (hero.HP <= 0)
                {
                    hero.IsAlive = false;
                }
                
                Console.WriteLine("the dragon fires back!!!");
                Console.WriteLine("Hero hp: {0}", this.hero.HP);
            }
            else
            {
                Console.WriteLine("type: \n1: Attack with sword \n2: Attack with magic fireball or \n3: Heal yourself\n");
                string attackTypeString = Console.ReadLine();
                int volInt = int.Parse(attackTypeString);
                AttackType input = (AttackType)volInt;
                switch (input)
                {
                    case AttackType.Sword:
                        Console.Clear();
                        Console.WriteLine("you swing your mighty sword!!!");
                        this.dragon.HP = this.dragon.HP - (Program.sword * (Program.swordChance <= 70 ? 1 : 0));
                        if (dragon.HP <= 0)
                        {
                            dragon.IsAlive = false;
                            break;
                        }
                        Console.WriteLine("Dragon hp: {0}", this.dragon.HP);
                        break;
                    case AttackType.Magic:
                        Console.Clear();
                        Console.WriteLine("you ingnite and launch a fireball");
                        this.dragon.HP = this.dragon.HP - Program.magic;
                        if (dragon.HP <= 0)
                        {
                            dragon.IsAlive = false;
                            break;
                        }
                        Console.WriteLine("Dragon hp: {0}", this.dragon.HP);
                        break;
                    case AttackType.Heal:
                        Console.Clear();
                        Console.WriteLine("you heal yourself with a soda");
                        this.hero.HP = this.hero.HP + (Program.heal * (this.hero.HP <= Program.starthp ? 1 : 0));
                        Console.WriteLine("hp: {0}", this.hero.HP);
                        break;
                    default:
                        break;
                }
            }

        }

    }
}
