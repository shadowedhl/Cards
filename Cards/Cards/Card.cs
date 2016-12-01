namespace Dominion.Cards
{
    public abstract class Card
    {
        public int VictoryTokens { get; protected set; }
        public int VictoryScore { get; protected set; }
        public CardType Type { get; protected set;}
        public int Actions { get; protected set; }
        public int DrawCards { get; protected set; }
        public int Buys { get; protected set; }
        public int Treasure { get; protected set; }
        public int Cost { get; protected set; }
        public virtual void Play ( Player player)
        {
            if (Type == CardType.Playable)
            {
                player.AddActions(Actions);
                player.AddBuys(Buys);
                player.AddTreasure(Treasure);
                player.AddVictoryTokens(VictoryTokens);
                player.DrawCards(DrawCards);
            }
        }
    }
}