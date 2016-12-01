using System;

namespace Dominion.Cards
{
    [Flags]
    public enum CardType
    {
        Playable = 1,
        Curse = 2,
        Victory = 4,
        Treasure = 8,
        Action = 16,
        Attack = 32,
        Reaction = 64,
    }
}