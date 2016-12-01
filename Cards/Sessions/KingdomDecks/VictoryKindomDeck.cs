using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominion.Cards.Victories;

namespace Dominion.Sessions.KingdomDecks
{
    public class VictoryKingdomDeck<T> : KingdomDeck<T> where T : VictoryCard
    {
        public VictoryKingdomDeck(T card, int cardCount, bool endGameOnDepletion):base(card, cardCount)
        {
            EndGameOnDepletion = endGameOnDepletion;
            
        }
        public bool EndGameOnDepletion { get; private set; }
       
    }
}
