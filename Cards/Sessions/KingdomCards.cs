using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominion.Sessions.KingdomDecks;
using Dominion.Cards;
using Dominion.Cards.Treasures;
using Dominion.Cards.Victories;

namespace Dominion.Sessions
{
    public class KingdomCards
    {
        public KingdomCards(List<KingdomDeck<Card>> sessionKingdomDecks, List<KingdomDeck<TreasureCard>> additionalTreasureDecks = null, List<VictoryKingdomDeck<VictoryCard>> additionalVictoryDecks = null)
        {
            SessionKingdomDecks = sessionKingdomDecks;
            TreasureCardKingdomDecks = new List<KingdomDeck<TreasureCard>>
            {
                new KingdomDeck<TreasureCard>(new Copper(), 30),
                new KingdomDeck<TreasureCard>(new Silver(), 30),
                new KingdomDeck<TreasureCard>(new Gold(), 30),
            };
            TreasureCardKingdomDecks.AddRange(additionalTreasureDecks);
            VictoryCardKingdomDecks = new List<VictoryKingdomDeck<VictoryCard>>
            {
                new VictoryKingdomDeck<VictoryCard>(new Estate(), 15, false),
                new VictoryKingdomDeck<VictoryCard>(new Duchy(), 15, false),
                new VictoryKingdomDeck<VictoryCard>(new Province(), 15, true),
            };
            VictoryCardKingdomDecks.AddRange(additionalVictoryDecks);

        }
        public List<VictoryKingdomDeck<VictoryCard>> VictoryCardKingdomDecks { get; private set; }
        public List<KingdomDeck<TreasureCard>> TreasureCardKingdomDecks { get; private set; }
        public List<KingdomDeck<Card>> SessionKingdomDecks { get; private set; }

        public bool GameShouldEnd => CheckForGameEnd();

        private bool CheckForGameEnd()
        {
            bool gameEnd = false;
            if (VictoryCardKingdomDecks.Any(d => d.IsDepleted && d.EndGameOnDepletion))
            {
                gameEnd = true;
            }

            int depletedDecks = VictoryCardKingdomDecks.Count(d => d.IsDepleted);
            depletedDecks += SessionKingdomDecks.Count(d => d.IsDepleted);
            depletedDecks += TreasureCardKingdomDecks.Count(d => d.IsDepleted);

            return gameEnd || depletedDecks > 2;
        }

        public Card BuyKingdomCard(Type cardType)
        {
            Card card = null;
            if (VictoryCardKingdomDecks.Any(d => d.CardInDeck.GetType() == cardType))
            {
                var deck = VictoryCardKingdomDecks.Where(d => d.CardInDeck.GetType() == cardType).FirstOrDefault();
                if (deck.Peek() != null)
                    card = deck.Pop();
            }
            else if (SessionKingdomDecks.Any(d => d.CardInDeck.GetType() == cardType))
            {
                var deck = SessionKingdomDecks.Where(d => d.CardInDeck.GetType() == cardType).FirstOrDefault();
                if (deck.Peek() != null)
                    card = deck.Pop();
            }
            else if (TreasureCardKingdomDecks.Any(d => d.CardInDeck.GetType() == cardType))
            {
                var deck = TreasureCardKingdomDecks.Where(d => d.CardInDeck.GetType() == cardType).FirstOrDefault();
                if (deck.Peek() != null)
                    card = deck.Pop();
            }
            return card;
        }
        
    }
}
