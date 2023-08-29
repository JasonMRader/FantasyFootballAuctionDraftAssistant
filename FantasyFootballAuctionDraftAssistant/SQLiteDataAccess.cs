using Dapper;
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
                    "FantasyTeamID, Cost, Year) values (@Name, @EstimatedValue, @Position, @NflTeam, @ByeWeek, @Drafted," +
                    " @FantasyTeamID, @Cost, @Year)", player);
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
                    "Cost = @Cost, Year = @Year WHERE ID = @ID", player);
            }
        }

        public static void SaveFantasyTeam(FantasyTeam team)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into FantasyTeams (Name, Owner) values (@Name, @Owner)", team);
            }
        }
        public static List<FantasyTeam> LoadFantasyTeams()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var teams = cnn.Query<FantasyTeam>("select * from FantasyTeams", new DynamicParameters()).ToList();
                var players = LoadPlayers();

                foreach (var team in teams)
                {
                    team.Players.AddRange(players.Where(p => p.FantasyTeamID == team.ID));
                    team.RecalculateBudget();
                    team.RecalculateRosterSpots();
                }

                return teams;
            }
            //using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            //{
            //    var output = cnn.Query<FantasyTeam>("select * from FantasyTeams", new DynamicParameters());
            //    return output.ToList();
            //}
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
