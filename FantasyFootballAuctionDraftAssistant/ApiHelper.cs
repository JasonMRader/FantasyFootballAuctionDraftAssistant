using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballAuctionDraftAssistant
{
    public class ApiHelper
    {
        private const string BASE_URL = "https://v1.american-football.api-sports.io/";
        private const string API_KEY = "1e21b1f3bb5a8ca46576d4563222775d";
        private RestClient client;
        private RestResponse response;

        public ApiHelper()
        {
            client = new RestClient(BASE_URL);
            
        }

        public List<Player> GetPlayersByTeamId(int teamId)
        {
            var client = new RestClient(BASE_URL);
            var request = new RestRequest();
            request.AddHeader("x-rapidapi-key", API_KEY);
            request.AddHeader("x-rapidapi-host", "v1.american-football.api-sports.io");

            request.AddParameter("team", teamId); // Add the team ID parameter

            RestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                // Assuming the API returns an array of players in the root
                var players = JsonConvert.DeserializeObject<List<Player>>(response.Content);
                return players;
            }
            else
            {
                throw new Exception($"Error fetching players. Status: {response.StatusCode}. Content: {response.Content}");
            }
        }
    }
}
