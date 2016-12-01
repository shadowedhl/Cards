using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion.Cards.Victories
{
    class Province:VictoryCard
    {
        public Province():base()
        {
            this.VictoryScore = 6;
            this.Cost = 8;
        }
    }
}
