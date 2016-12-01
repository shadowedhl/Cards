using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion.Cards.Treasures
{
    public class Gold : TreasureCard
    {
        public Gold():base()
        {
            this.Treasure = 3;
            this.Cost = 6;
        }
    }
}
