using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Grid
    {
        public enum PlaceShipDirestion
        {
            Horizontal, Vertical
        }

        public Point[,] Ocean { get; set; }
        public List<Ship> ListOfShipes { get; set; }
        public bool AllShipsDestroyed { 
            get
            {
                return this.ListOfShipes.All(x => x.IsDestroyed);
            } 
        }
        public int CombateRound { get; set; }

        //constructor from page 62
        public Grid(Ship ShipToPlace, PlaceShipDirestion direction, int startX, int startY)
        {
            //for loop
            this.Ocean = new Point[10,10];

            for (int y = 0; y < 10; y++)
			{
			    for (int x = 0; x < 10; x++)
			    {
			        this.Ocean[x,y]=new Point(x,y,Point.PointStatus.Empty);
			    }
			}

            this.ListOfShipes = new List<Ship>();
            this.ListOfShipes.Add(new Ship(Ship.ShipType.Carrier));
            this.ListOfShipes.Add(new Ship(Ship.ShipType.Battleship));
            this.ListOfShipes.Add(new Ship(Ship.ShipType.Cuirser));
            this.ListOfShipes.Add(new Ship(Ship.ShipType.Submarine));
            this.ListOfShipes.Add(new Ship(Ship.ShipType.MineSweeper));   
         
            PlaceShip(this.ListOfShipes[0], PlaceShipDirestion.Horizontal, 0,0);
            PlaceShip(this.ListOfShipes[1], PlaceShipDirestion.Horizontal, 0,1);
            PlaceShip(this.ListOfShipes[2], PlaceShipDirestion.Horizontal, 0,2);
            PlaceShip(this.ListOfShipes[3], PlaceShipDirestion.Horizontal, 0,3);
            PlaceShip(this.ListOfShipes[4], PlaceShipDirestion.Horizontal, 0,4);
        }

        private void PlaceShip(Ship shipToPlace, PlaceShipDirestion direction, int startx, int starty){
            for (int i = 0; i < shipToPlace.Length; i++)
			{
			    Point aPoint = this.Ocean[startx,starty];
                aPoint.PointState = Point.PointStatus.Ship;
                shipToPlace.OccupiedPoints.Add(aPoint);
                if (direction == PlaceShipDirestion.Horizontal)
	                {
		                startx++;
	                }
                else
	                {
                        starty++;
	                }
			}
        }

        private void DisplayOcean()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~     Battle Ship    ~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9 ");
            Console.WriteLine(y + "|");
            for (int x = 0; x < 10; x++)
			{
			    Point aPoint = this.Ocean[x,y];
                switch (aPoint.PointState)
	            {
		            case Point.PointStatus.Empty:
                        Console.Write("[ ]");
                        break;
                    case Point.PointStatus.Ship:
                        Console.Write("[S]");
                        break;
                    case Point.PointStatus.Hit:
                        Console.Write("[X]");
                        break;
                    case Point.PointStatus.Miss:
                        Console.Write("[M]");
                        break;
                    default:
                        break;
	            }
			}
            Console.WriteLine();
        }

        public void PlayGame()
        {
            while(!AllShipsDestroyed)
            {
                DisplayOcean();
                string xInput = " ";
                String yInput = " ";
                while (true)
	            {
    	            Console.WriteLine("Enter X");
                    xInput=Console.ReadLine();
                    Console.WriteLine("Enter Y");
                    yInput=Console.ReadLine();
	            }
                Target(int.Parse(xInput), int.Parse(yInput));
                this.CombateRound++;
            }
            Console.WriteLine("you won after {0} ronuds", this.CombateRound);
        }

    }
}
