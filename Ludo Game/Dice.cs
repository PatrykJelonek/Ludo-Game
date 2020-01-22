using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_Game
{
    public class Dice
    {
        private const int MAX_VALUE = 6;

        private readonly Random random;
        private int value;

        public Dice(Random random)
        {
            this.random = random;
        }

        public int Roll()
        {
            this.value = this.random.Next(Dice.MAX_VALUE) + 1;

            return this.value;
        }

        public int Value
        {
            get { return this.value; }
        }
    }
}