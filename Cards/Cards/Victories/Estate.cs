using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion.Cards.Victories
{
    public class Estate:VictoryCard
    {
        public Estate():base()
        {
            this.VictoryScore = 1;
            this.Cost = 2;
        }
    }
}
