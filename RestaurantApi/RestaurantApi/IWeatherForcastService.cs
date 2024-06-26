
namespace RestaurantApi
{
    public interface IWeatherForcastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}