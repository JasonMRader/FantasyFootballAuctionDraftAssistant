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
        public List<Player> AllPlayers { get; private set; }
        public List<Player> FreeAgents { get; private set; } = new List<Player> { };
        public List<Player> DraftedPlayers { get; private set; } = new List<Player> { };
        public List<Player> Keepers { get; private set; } = new List<Player> { };
        public List<FantasyTeam> AllFantasyTeams { get; private set; }
        public FantasyTeam? MyTeam { get; private set; }
        public FantasyTeam DisplayTeam { get; set; }
        public Player SelectedPlayerOnRoster { get; set; }
        public Player? PlayerOnTheClock { get; set; }
        private int currentPickNumber = 1;
        public DraftManager(FantasyTeam myTeam) 
        {
            this.MyTeam = myTeam;
            this.AllPlayers = SQLiteDataAccess.LoadPlayers();
            this.AllFantasyTeams = SQLiteDataAccess.LoadFantasyTeams(this.AllPlayers).OrderByDescending(team => team.Name).ToList();
            //this.AllFantasyTeams = SQLiteDataAccess.LoadFantasyTeams(this.AllPlayers);
            //this.AllFantasyTeams.OrderBy(team => team.Name);
        }
        public DraftManager()
        {
           
            this.AllPlayers = SQLiteDataAccess.LoadPlayers();
            //this.AllFantasyTeams = SQLiteDataAccess.LoadFantasyTeams(this.AllPlayers);
            this.AllFantasyTeams = SQLiteDataAccess.LoadFantasyTeams(this.AllPlayers).OrderByDescending(team => team.Name).ToList();
            this.MyTeam = AllFantasyTeams.FirstOrDefault(team => team.Name == "Disappointing Monday");
            //this.AllFantasyTeams.OrderByDescending(team => team.Name);
        }
        private void GetMyTeam()
        {
            this.MyTeam = AllFantasyTeams.FirstOrDefault(team => team.Name == "Disappointing Monday");
        }
        public void StartDraft()
        {

            Keepers.Clear();
            FreeAgents.Clear();
            // Register all keepers with pickNumber 0
            foreach (var player in this.AllPlayers.Where(p => p.Keeper))
            {
                //RecordMove(player, player.fantasyTeam, true, 0);
                var move = new RosterMoves(player, player.FantasyTeam, true, 0);
                Keepers.Add(player);
                FreeAgents.Remove(player);
                Moves.Add(move);
            }
            foreach (var player in this.AllPlayers.Where(p => p.Drafted == true && p.Keeper == false))
            {
                DraftedPlayers.Add(player);
                FreeAgents.Remove(player);
                currentPickNumber ++;
            }
            CorrectDraftOrder();
            FreeAgents.AddRange(this.AllPlayers.Where(p => !p.Keeper && !p.Drafted));
        }
        public void RecordDraftPick(FantasyTeam team, int cost)
        {
            // If the player is a keeper, we don't update the draft pick number.
            if (PlayerOnTheClock != null)
            {
                var move = new RosterMoves(this.PlayerOnTheClock, team, false, currentPickNumber);

                // Update the Player's Keeper and DraftPickNumber properties
                this.PlayerOnTheClock.Keeper = false;
                this.PlayerOnTheClock.DraftPickNumber = currentPickNumber;
                this.PlayerOnTheClock.FantasyTeam = team;
                this.PlayerOnTheClock.Drafted = true;
                team.AddPlayer(PlayerOnTheClock, cost);
                DraftedPlayers.Add(this.PlayerOnTheClock);
                FreeAgents.Remove(this.PlayerOnTheClock);
                Moves.Add(move);
                currentPickNumber++;
                SQLiteDataAccess.UpdatePlayer(PlayerOnTheClock);
            }
            else
            {
                MessageBox.Show("There is no player selected!");
            }

           
        }
        private void CorrectDraftOrder()
        {
            currentPickNumber = 1;
            this.DraftedPlayers = this.DraftedPlayers.OrderBy(p => p.DraftPickNumber).ToList();
            for (int i = 0; i < this.DraftedPlayers.Count; i++)
            {
                
                if (DraftedPlayers[i].DraftPickNumber != currentPickNumber)
                {
                    DraftedPlayers[i].DraftPickNumber = currentPickNumber;
                }
                currentPickNumber++;
            }
            
            
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
            if (player.Keeper == false)
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
        public void UndraftPlayer()
        {
            this.DisplayTeam.RemovePlayer(SelectedPlayerOnRoster);
            this.SelectedPlayerOnRoster.Drafted = false;
            this.FreeAgents.Add(SelectedPlayerOnRoster);
            this.DraftedPlayers.Remove(SelectedPlayerOnRoster);
            CorrectDraftOrder();
            SQLiteDataAccess.UpdatePlayer(SelectedPlayerOnRoster);
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
