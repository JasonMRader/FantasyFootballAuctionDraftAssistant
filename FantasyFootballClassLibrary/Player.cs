using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballAuctionDraftAssistant
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        // make enum
        //public PlayerPosition Position { get; set; }
        public int EstimatedValue { get; set; }
        public int AlternateValue { get; set; }
        public int PositionRank { get; set; }
        public int AverageValue 
        {
            get
            {
                if (AlternateValue > 0)
                {
                    return (AlternateValue + EstimatedValue)/2;
                }
                else
                {
                    return -1;
                }
            }
        }
        public string NflTeam { get; set; }
        public int ByeWeek { get; set; }
        public bool Drafted { get; set; }
        public FantasyTeam? FantasyTeam { get; set; }
        public int FantasyTeamID { get; set; }
        public int Cost { get; set; }
        public int Year { get; set; }
        public bool Keeper { get; set; }
        public string? Notes { get; set; }
        public int? DraftPickNumber { get; set; }
        public string PositionString { get; set; }
        public int ValueDifference
        {
            get { return EstimatedValue - Cost; }
        }

        public PlayerPosition Position
        {
            get
            {
                return Enum.TryParse(PositionString, out PlayerPosition position) ? position : PlayerPosition.None; // Assuming you've added a 'None' enum value for invalid conversions.
            }
            set
            {
                PositionString = value.ToString();
            }
        }
        public enum PlayerPosition
        {
            QB, RB, WR, TE, DEF, K, None
        } 

        
    }
}
