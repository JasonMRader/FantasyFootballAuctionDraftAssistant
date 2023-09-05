using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballAuctionDraftAssistant
{
    public class FantasyTeamEventArgs : EventArgs
    {
        public FantasyTeam Team { get; private set; }

        public FantasyTeamEventArgs(FantasyTeam team)
        {
            Team = team;
        }
    }
}
