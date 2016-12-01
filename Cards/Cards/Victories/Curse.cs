using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion.Cards.Victories
{
    public class Curse: VictoryCard
    {
        public Curse():base()
        {
            this.Type = this.Type | CardType.Curse;
            this.VictoryScore = -1;
            this.Cost = 0;
        }
    }
}
