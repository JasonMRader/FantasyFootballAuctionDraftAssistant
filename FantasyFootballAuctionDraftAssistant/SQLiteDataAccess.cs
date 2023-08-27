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
                cnn.Execute("insert into Players (Name, EstimatedValue, Position) values (@Name, @EstimatedValue, @Position)", player);
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
                var output = cnn.Query<FantasyTeam>("select * from FantasyTeams", new DynamicParameters());
                return output.ToList();
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
