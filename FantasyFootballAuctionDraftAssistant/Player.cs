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
        public string NflTeam { get; set; }
        public int ByeWeek { get; set; }
        public bool Drafted { get; set; }
        public string FantasyTeam { get; set; }
        public int Cost { get; set; }
        public string PositionString { get; set; }

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
