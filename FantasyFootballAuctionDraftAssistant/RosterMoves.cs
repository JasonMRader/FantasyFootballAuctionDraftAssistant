using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballAuctionDraftAssistant
{
    public class RosterMoves
    {
        public Player Player { get; set; }
        public FantasyTeam Team { get; set; }
        public bool Keeper { get; set; }
        public int pickNumber { get; set; }
        public RosterMoves() { }

        public RosterMoves(Player player, FantasyTeam team, bool keeper, int pickNo)
        {
            Player = player;
            Team = team;
            Keeper = keeper;
            pickNumber = pickNo;
        }

    }
}
