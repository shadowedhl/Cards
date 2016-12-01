using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion.Cards.Treasures
{
    public class Copper: TreasureCard
    {
        public Copper():base()
        {
            this.Treasure = 1;
            this.Cost = 0;
        }
    }
}
