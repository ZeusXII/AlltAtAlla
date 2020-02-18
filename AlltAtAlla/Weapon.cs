using System;
using System.Collections.Generic;
using System.Text;

namespace AlltAtAlla
{
    class Weapon
    {
        protected int minDamage;
        protected int maxDamage;

        Random generator = new Random();
        public int Damage()
        {
            minDamage = generator.Next(1, 3);
            maxDamage = generator.Next(1, 9);

            return 0;
        }
        public string PrintStats()
        {

            return "Weapon: "  + "MinumumDmg " + minDamage + "maximumDmg: " + maxDamage;
        }
    }
}
