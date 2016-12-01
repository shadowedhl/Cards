using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion.Cards.Actions
{
    abstract class ActionCard : Card
    {
        public ActionCard()
        {
            this.Type = CardType.Playable | CardType.Action;
        }

        public bool UseAction(Player player)
        {
            bool playedCard = false;
            if (player.UseAction())
            {
                this.Play(player);
                playedCard = true;
            }

            return playedCard;

        }
    }
}
