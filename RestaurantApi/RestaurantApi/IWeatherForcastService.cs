
namespace RestaurantApi
{
    public interface IWeatherForcastService
    {
        IEnumerable<WeatherForecast> Get(int resultsCount, int mixTemp, int maxTemp);
    }
}