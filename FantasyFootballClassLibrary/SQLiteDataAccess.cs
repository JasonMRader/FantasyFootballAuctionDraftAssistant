using Dapper;
//using Microsoft.Data.Sqlite;
//using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballAuctionDraftAssistant
{
    public class SQLiteDataAccess
    {
        public static List<Player> LoadPlayers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Player>("select * from Players", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SavePlayer(Player player)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Players (Name, EstimatedValue, Position, NflTeam, ByeWeek, Drafted, " +
                    "FantasyTeamID, Cost, Year, AlternateValue, PositionRank, Notes) values (@Name, @EstimatedValue, @Position, @NflTeam, @ByeWeek, @Drafted," +
                    " @FantasyTeamID, @Cost, @Year, @AlternateValue, @PositionRank, @Notes)", player);
            }
        }
        public static void DeletePlayer(int playerId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Players WHERE PlayerId = @Id", new { Id = playerId });
            }
        }
        public static void DeleteAllPlayers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Players");
            }
        }
        public static void UpdatePlayer(Player player)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Players SET Name = @Name, EstimatedValue = @EstimatedValue, Position = @Position, " +
                    "NflTeam = @NflTeam, ByeWeek = @ByeWeek, Drafted = @Drafted, FantasyTeamID = @FantasyTeamID, " +
                    "Cost = @Cost, Year = @Year, Keeper = @Keeper, DraftPickNumber = @DraftPickNumber" +
                    ", Notes = @Notes, AlternateValue = @AlternateValue, PositionRank = @PositionRank WHERE ID = @ID", player);
            }
        }
        public static void UpdateTeam(FantasyTeam team)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE FantasyTeams SET Name = @Name, Owner = @Owner WHERE ID = @ID", team);
            }
        }

        public static void SaveFantasyTeam(FantasyTeam team)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into FantasyTeams (Name, Owner) values (@Name, @Owner)", team);
            }
        }
        public static List<FantasyTeam> LoadFantasyTeams(List <Player> players)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var teams = cnn.Query<FantasyTeam>("select * from FantasyTeams", new DynamicParameters()).ToList();
                //var players = LoadPlayers();

                foreach (var team in teams)
                {
                    

                    var teamPlayerIndices = players.Select((p, index) => new { Player = p, Index = index })
                               .Where(p => p.Player.FantasyTeamID == team.ID)
                               .ToList();

                    foreach (var playerIndex in teamPlayerIndices)
                    {
                        players[playerIndex.Index].FantasyTeam = team;
                    }
                    var teamPlayers = players.Where(p => p.FantasyTeamID == team.ID).ToList();

                    //foreach (var player in players)
                    //{
                    //    player.FantasyTeam = team;  // Assign the fantasy team to the player's FantasyTeam property
                    //}

                    team.Players.AddRange(teamPlayers);
                    team.Keeper = team.Players.FirstOrDefault(p => p.Keeper);
                    team.RecalculateBudget();
                    team.RecalculateRosterSpots();
                }
                //teams.OrderBy(t => t.Name);
                return teams;
            }
        }

        //public static List<FantasyTeam> LoadFantasyTeams()
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var teams = cnn.Query<FantasyTeam>("select * from FantasyTeams", new DynamicParameters()).ToList();
        //        var players = LoadPlayers();

        //        foreach (var team in teams)
        //        {
        //            team.Players.AddRange(players.Where(p => p.FantasyTeamID == team.ID));
        //            team.Keeper = team.Players.FirstOrDefault(p => p.Keeper);
        //            team.RecalculateBudget();
        //            team.RecalculateRosterSpots();
        //        }

        //        return teams;
        //    }
        //    //using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    //{
        //    //    var output = cnn.Query<FantasyTeam>("select * from FantasyTeams", new DynamicParameters());
        //    //    return output.ToList();
        //    //}
        //}
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
