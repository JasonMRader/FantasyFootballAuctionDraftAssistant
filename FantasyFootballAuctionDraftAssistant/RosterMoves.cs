using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballAuctionDraftAssistant
{
    public class RosterMoves
    {
        Player Player { get; set; }
        FantasyTeam Team { get; set; }
        bool Keeper { get; set; }
        int pickNumber { get; set; }
    }
}
