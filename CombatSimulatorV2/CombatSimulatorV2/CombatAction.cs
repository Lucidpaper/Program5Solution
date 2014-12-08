using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulatorV2
{
    public enum AttackType
    {
        Sword = 1, Magic, Heal
    }
    class CombatAction
    {
        static Random rng = new Random();

        public int SwordValue { get { return rng.Next(20, 35); } }
        public int MagicValue { get { return rng.Next(10, 15); } }
        public int HealValue { get { return rng.Next(10, 20); } }
    }
}
