using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion.Cards.Treasures
{
    public abstract class TreasureCard : Card
    {
        public TreasureCard()
        {
            this.Type = CardType.Playable | CardType.Treasure;
        }
    }
}
