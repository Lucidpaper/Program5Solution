using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulatorV2
{
    class Player : Character
    {
        public Player(int newHP, string newName)
        {
            this.HP = newHP;
            this.Name = newName;
            this.IsAlive = true;
        }
    }
}
