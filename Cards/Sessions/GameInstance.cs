using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion.Sessions
{
    public class GameInstance
    {
        public GameInstance(List<Player> players, KingdomCards kingdomCards)
        {
            Players = players;
            Kingdom = kingdomCards;
            currentPlayer = players.OrderBy(p => p.TurnOrder).First();
            currentPhase = TurnStep.Action;
        }
        public void TakePlayerTurn()
        {
            if(currentPlayer.TurnPhase==TurnStep.NextPlayer)
                currentPlayer = Players.FirstOrDefault(p=>p.TurnOrder==currentPlayer.TurnOrder+1)??Players.OrderBy(p => p.TurnOrder).First();
        }
        public List<Player> Players { get; set; }
        public KingdomCards Kingdom { get; set; }
        private Player currentPlayer { get; set; }
        private TurnStep currentPhase { get; set; }
    }
}
