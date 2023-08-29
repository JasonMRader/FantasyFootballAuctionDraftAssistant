using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballAuctionDraftAssistant
{
    public class DraftManager
    {
        public List<RosterMoves> Moves { get; private set; } = new List<RosterMoves>();
        public List<Player> FreeAgents { get; private set; } = new List<Player> { };
        public List<Player> DraftedPlayers { get; private set; } = new List<Player> { };
        public List<Player> Keepers { get; private set; } = new List<Player> { };
        
        private int currentPickNumber = 1;

        public void StartDraft(List<Player> allPlayers)
        {
            Keepers.Clear();
            FreeAgents.Clear();
            // Register all keepers with pickNumber 0
            foreach (var player in allPlayers.Where(p => p.Keeper))
            {
                RecordMove(player, player.fantasyTeam, true, 0);
                Keepers.Add(player);
            }
            FreeAgents.AddRange(allPlayers.Where(p => !p.Keeper));
        }

        public void RecordMove(Player player, FantasyTeam team, bool keeper, int pickNo)
        {
            // If the player is a keeper, we don't update the draft pick number.
            if (!keeper)
            {
                pickNo = currentPickNumber++;
            }

            var move = new RosterMoves(player, team, keeper, pickNo);

            // Update the Player's Keeper and DraftPickNumber properties
            player.Keeper = keeper;
            player.DraftPickNumber = pickNo;
            if (player.Keeper = false)
            {
                DraftedPlayers.Add(player);
            }
            
            FreeAgents.Remove(player);
            Moves.Add(move);
        }

        public IEnumerable<RosterMoves> ListAllMoves()
        {
            return Moves;
        }

        public IEnumerable<RosterMoves> ListMovesByTeam(FantasyTeam team)
        {
            return Moves.Where(move => move.Team == team);
        }

        public void UndoLastMove()
        {
            if (Moves.Any())
            {
                var lastMove = Moves.Last();

                // If it's not a keeper, decrement the pick number.
                if (!lastMove.Keeper)
                {
                    currentPickNumber--;
                }

                // Reset the Player's Keeper and DraftPickNumber properties if necessary
                lastMove.Player.Keeper = false;  // or whatever the default state is
                lastMove.Player.DraftPickNumber = 0;  // or whatever the default state is

                Moves.Remove(lastMove);
            }
        }
    }


}
