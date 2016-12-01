using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion.Cards.Treasures
{
    public class Silver : TreasureCard
    {
        public Silver():base()
        {
            this.Treasure = 2;
            this.Cost = 3;
        }
    }
}
