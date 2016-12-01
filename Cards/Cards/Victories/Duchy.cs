using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion.Cards.Victories
{
    public class Duchy:VictoryCard
    {
        public Duchy():base()
        {
            this.VictoryScore = 3;
            this.Cost = 5;
        }
    }
}
