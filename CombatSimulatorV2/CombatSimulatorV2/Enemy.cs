using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulatorV2
{
    class Enemy : Character
    {
        public Enemy(int newHP, string newName)
        {
            this.HP = newHP;
            this.Name = newName;
            this.IsAlive = true;
            while (this.HP <=0)
            {
                this.IsAlive = false;
            }
        }
    }
}
