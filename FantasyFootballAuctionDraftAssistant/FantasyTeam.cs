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
        public string Name { get; set; }
        private int _budget = 200;
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
            this.Players.Add(player);
            RecalculateBudget();
        }
        public void RemovePlayer(Player player)
        {
            
            this.Players.Remove(player);
            RecalculateBudget();
        }
        private void RecalculateBudget()
        {
            _budget = 200 - Players.Sum(player => player.Cost);
        }
        public int CountPosition(Player.PlayerPosition position)
        {
            return Players.Count(player => player.Position == position);
        }


        
    }
}
