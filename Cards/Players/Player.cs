using System.Linq;
using System.Collections.Generic;
using Dominion.Cards;
using Dominion.Sessions;

namespace Dominion
{
    public class Player
    {
        public Player(int turnOrder)
        {
            TurnOrder = turnOrder;
            TurnPhase = TurnStep.Action;
            for(int i = 0; i < 3; i++)
            {
                //Buy Estate Victory Card
            }
            for(int i = 0; i < 7; i++)
            {
                //Buy Copper Treasure Card
            }
            DrawNewHand();
        }

        private int TurnStartActions { get; set; }
        private int TurnStartTreasure { get; set; }
        private int TurnStartBuys { get; set; }
        private int TurnStartCards { get; set; }

        public int TurnOrder { get; private set; }
        public TurnStep TurnPhase { get; private set; }
        public int Actions { get; private set; }
        public int Buys { get; private set; }
        public int Treasure { get; private set; }

        public List<Card> DrawDeck { get; private set; }
        public List<Card> Hand { get; private set; }
        public List<Card> InPlay { get; private set; }
        public List<Card> DiscardPile { get; private set; }
        public int VictoryTokens { get; private set; }


        private void DrawNewHand()
        {
            Actions = TurnStartActions;
            Buys = TurnStartBuys;
            Treasure = TurnStartTreasure;
            DrawCards(TurnStartCards);
        }

        public void StartTurn()
        {
            DrawNewHand();
            TurnPhase = TurnStep.Action;
        }
        public void PlayCardFromHand(Card card)
        {
            if (Hand.Contains(card))
            {
                InPlay.Add(card);
                Hand.Remove(card);
            }
        }
        public void DiscardCardsInHand()
        {
            DiscardPile.AddRange(Hand);
            Hand.Clear();
        }

        public void FinishTurn()
        {
            DiscardCardsInHand();
            DiscardCardsInPlay();
            DrawNewHand();
            TurnPhase = TurnStep.NextPlayer;
        }

        private void DiscardCardsInPlay()
        {
            DiscardPile.AddRange(InPlay);
            InPlay.Clear();
        }

        internal void AddActions(int actions)
        {
            Actions += actions;
        }

        internal void AddBuys(int buys)
        {
            Buys += buys;
        }

        internal void AddTreasure(int treasure)
        {
            Treasure += treasure;
        }

        public void AddVictoryTokens(int victoryTokens)
        {
            VictoryTokens = victoryTokens;
        }

        internal bool UseBuy()
        {
            bool canBuy = false;
            if (Buys > 0)
            {
                Buys--;
                canBuy = true;
            }
            return canBuy;
        }

        internal bool UseAction()
        {
            bool usedAction = false;
            if (Actions > 0)
            {
                Actions--;
                usedAction = true;
            }
            return usedAction;
        }

        internal void DrawCards(int drawCards)
        {
            for (int i = 0; i < drawCards; i++)
            {
                if (DrawDeck.Count == 0)
                {
                    ReshuffleDrawDeck();
                }

                if (DrawDeck.Count > 0)
                {
                    Card cardDrawn = DrawDeck.First();
                    DrawDeck.Remove(cardDrawn);
                    Hand.Add(cardDrawn);
                }
            }
        }

        private void ReshuffleDrawDeck()
        {
            if (DiscardPile.Count > 0)
            {
                DrawDeck.AddRange(DiscardPile.Shuffle());
                DiscardPile.Clear();
            }
        }
    }
}