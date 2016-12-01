using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominion.Cards;

namespace Dominion.Sessions.KingdomDecks
{
    public class KingdomDeck<T>:Stack<T> where T : Card
    {
        public KingdomDeck(T card, int cardCount)
        {
            CardInDeck = card;
            for (int i = 0; i < cardCount; i++)
            {
                this.Push(card);
            }
        }
        public T CardInDeck { get; private set; }
        public bool IsDepleted => this.Count == 0;
    }
}
