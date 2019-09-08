using WeatherPro.Core.Models;
using System.Threading.Tasks;

namespace WeatherPro.Core.Services
{
    public interface IOpenWeatherApi
    {
        Task<Response> GetWeatherInfoAsync(string place ,string apiKey);
    }
}
