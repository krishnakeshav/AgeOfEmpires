using AgeOfEmpires.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AgeOfEmpires
{
    public class GameProxy : IGameProxy
    {
        static readonly HttpClient client = new HttpClient();

        public async Task<Unit> GetUnitInfo(int id)
        {
            Uri uri = new Uri($"https://age-of-empires-2-api.herokuapp.com/api/v1/unit/{id}");
            string responseBody = await client.GetStringAsync(uri);
            Unit unit = JsonConvert.DeserializeObject<Unit>(responseBody);
            return unit;
        }
    }
}
