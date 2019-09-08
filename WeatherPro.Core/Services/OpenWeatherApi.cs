using System.Net.Http;
using System.Threading.Tasks;
using WeatherPro.Core.Models;
using Newtonsoft.Json.Linq;
using WeatherPro.Core.Services;

namespace WeatherPro.Core.Services
{
    public class OpenWeatherApi : IOpenWeatherApi
    {
        public async Task<Response> GetWeatherInfoAsync(string place, string apiKey)
        {
            string apiBase = "https://api.openweathermap.org/data/2.5/weather?q=";

            string url = apiBase + place + "&appid=" + apiKey + "&units=metric";
            var handler = new HttpClientHandler();
            var client = new HttpClient(handler);
            string result = await client.GetStringAsync(url);

            var resultObj = JObject.Parse(result);

            return new Response { IsSuccess = true, Message = "Getting data..", Result = resultObj };
        }
    }
}
