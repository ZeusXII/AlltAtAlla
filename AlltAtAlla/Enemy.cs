using System;
using System.Collections.Generic;
using System.Text;

namespace AlltAtAlla
{
    class Enemy : Character
    {
        public Enemy()
        {
            hp = 100;
            name = "Monstertron";
            minDamage = 5;
            maxDamage = 15;
        }

    }
}
