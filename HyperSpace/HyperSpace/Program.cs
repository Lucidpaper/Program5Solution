using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HyperSpace
{
    class Program
    {
        static void Main()
        {
            ResetBuffer();
            Random rng = new Random();
            List<Unit> ObstacleList = new List<Unit>();
            int livesCount = 3, score = 0, speed = 0;
            char[] symbolList = { '*', '!', '.', ':', ';', ':', '\'', '\"' };

            Unit Tesla = new Unit();
            Tesla.x = (Console.WindowWidth / 2) - 1;
            Tesla.y = Console.WindowHeight - 1;
            Tesla.color = ConsoleColor.White;
            Tesla.symbol = '^';

            while (true)
            {
                bool Smashed = false;

                int newSpaceRiftChance = rng.Next(0, 100);

                if (newSpaceRiftChance < 10)
                {
                    Unit newSpaceRift = new Unit();
                    newSpaceRift.x = rng.Next(0, Console.WindowWidth - 2);
                    newSpaceRift.y = 5;
                    newSpaceRift.color = ConsoleColor.Red;
                    newSpaceRift.symbol = '@';
                    ObstacleList.Add(newSpaceRift);
                }
                else
                {
                    Unit newInitObstacle = new Unit();
                    newInitObstacle.x = rng.Next(0, Console.WindowWidth - 2);
                    newInitObstacle.y = 5;
                    newInitObstacle.color = ConsoleColor.Cyan;
                    newInitObstacle.symbol = symbolList[rng.Next(0, 7)];
                    ObstacleList.Add(newInitObstacle);
                }


                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                    while (Console.KeyAvailable) { Console.ReadKey(true); }
                    if (keyPressed.Key == ConsoleKey.LeftArrow)
                    {
                        if (Tesla.x > 0)
                        {
                            Tesla.x--;
                        }
                    }
                    if (keyPressed.Key == ConsoleKey.RightArrow)
                    {
                        if (Tesla.x < Console.WindowWidth - 2)
                        {
                            Tesla.x++;
                        }
                    }
                }


                List<Unit> newList = new List<Unit>();
                for (int i = 0; i < ObstacleList.Count; i++)
                {
                    Unit oldObstacle = ObstacleList[i];
                    Unit NewMovedObsacle = new Unit();
                    NewMovedObsacle.x = oldObstacle.x;
                    NewMovedObsacle.y = oldObstacle.y + 1;
                    NewMovedObsacle.color = oldObstacle.color;
                    NewMovedObsacle.symbol = oldObstacle.symbol;


                    if (NewMovedObsacle.symbol == '@' && NewMovedObsacle.x == Tesla.x && NewMovedObsacle.y == Tesla.y)
                    {
                        score = score + 10;
                        if (speed > 50)
                        {
                            speed = speed - 50;
                        }
                        else if (speed <= 50)
                        {
                            speed = 0;
                        }


                    }

                    if (NewMovedObsacle.symbol != '@' && NewMovedObsacle.x == Tesla.x && NewMovedObsacle.y == Tesla.y)
                    {
                        livesCount--;
                        Smashed = true;
                        speed = 0;
                        if (livesCount <= 0)
                        {
                            PrintStringAtPosition(7, 2, "Lives: " + livesCount, ConsoleColor.Green);
                            PrintStringAtPosition(42, 2, "GAME OVER", ConsoleColor.Red);
                            PrintStringAtPosition(33, 3, "Press [enter] to continue", ConsoleColor.Red);
                            Console.ReadLine();
                            livesCount = 3;
                        }
                    }
                    if (NewMovedObsacle.y < Console.WindowHeight)
                    {
                        newList.Add(NewMovedObsacle);
                    }
                    else
                    {
                        score++;
                    }
                }
                ObstacleList = newList;


                Console.Clear();


                if (Smashed)
                {
                    PrintAtPosition(Tesla.x, Tesla.y, '@', ConsoleColor.Red);
                    ObstacleList.Clear();
                }
                else
                {
                    PrintAtPosition(Tesla.x, Tesla.y, Tesla.symbol, Tesla.color);
                }


                foreach (Unit obstacle in ObstacleList)
                {
                    PrintAtPosition(obstacle.x, obstacle.y, obstacle.symbol, obstacle.color);
                }


                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    PrintAtPosition(i, 5, '=', ConsoleColor.DarkRed);
                }
                PrintStringAtPosition(7, 2, "Lives: " + livesCount, ConsoleColor.Green);
                PrintStringAtPosition(14, 2, string.Concat(Enumerable.Repeat("^ ", livesCount).ToArray()), ConsoleColor.White);
                PrintStringAtPosition(20, 2, "Score: " + score, ConsoleColor.Green);
                PrintStringAtPosition(20, 3, "Speed: " + speed, ConsoleColor.Green);


                if (speed < 170)
                {
                    speed++;
                }
                Thread.Sleep(250 - speed);
            }
        }

        static void ResetBuffer()
        {
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
        }
        static void PrintAtPosition(int x, int y, char symbol, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }
        static void PrintStringAtPosition(int x, int y, string text, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(text);
        }
        class Unit
        {
            public int x, y;
            public ConsoleColor color;
            public char symbol;
        }
      
    }
}
