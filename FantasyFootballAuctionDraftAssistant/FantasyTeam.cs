using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballAuctionDraftAssistant
{
    public class FantasyTeam
    {
        public FantasyTeam() 
        { 
            this.Players = new List<Player>();
            
        }
        public FantasyTeam(string teamName, string ownerName)
        {
            this.Name = teamName;
            this.Owner = ownerName;
            this.Players = new List<Player>();
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public Player Keeper { get; set; }
        public string Owner { get; set; }
        private int _budget = 200;
        private int _rosterSpots = 16;
        public int RosterSpots
        {
            get { return _rosterSpots; }
            set { _rosterSpots = value;}
        }
        public int Budget
        {
            get { return _budget; }
            set { _budget = value; }
        }
        public List<Player> Players { get; set; }
        public void AddPlayer(Player player, int Cost)
        {
            player.Cost = Cost;
            player.Drafted = true;
            player.FantasyTeamID = this.ID;
            player.FantasyTeam = this;
            this.Players.Add(player);
            RecalculateBudget();
            RecalculateRosterSpots();
        }
        public void RemovePlayer(Player player)
        {
            
            player.Cost = 0;
            player.Drafted = false;
            player.FantasyTeam = null;
            player.FantasyTeamID = 0;
            player.DraftPickNumber = null;
            this.Players.Remove(player);
            RecalculateBudget();
            RecalculateRosterSpots();
        }
        public void RecalculateBudget()
        {
            _budget = 200 - Players.Sum(player => player.Cost);
        }
        public void RecalculateRosterSpots()
        {
            _rosterSpots = 16 - Players.Count();
        }
        public int CountPosition(Player.PlayerPosition position)
        {
            return Players.Count(player => player.Position == position);
        }
        public int TeamValueDifference()
        {
            int difference = 0;
            foreach (Player player in Players)
            {
                difference += player.ValueDifference;
            }
            return difference;
        }
        public void SetKeeper(Player newKeeper)
        {
            // If the player is not already part of the team, throw an exception or handle it accordingly
            if (!Players.Any(p => p.ID == newKeeper.ID))
            {
                throw new InvalidOperationException("The provided player is not part of this fantasy team.");
            }

            // Unset any existing keeper on the team
            foreach (var player in Players)
            {
                if (player.Keeper)
                {
                    player.Keeper = false;
                }
            }

            // Set the new keeper
            newKeeper.Keeper = true;
            Keeper = newKeeper;
        }



    }
}
