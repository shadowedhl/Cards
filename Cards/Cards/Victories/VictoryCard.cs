using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion.Cards.Victories
{
    public abstract class VictoryCard: Card
    {
        public int Points { get; protected set; }
        public VictoryCard()
        {
            this.Type = CardType.Victory;
        }
    }
}
