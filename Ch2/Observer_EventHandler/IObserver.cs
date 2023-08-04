public interface IObserver
{
    void OnWeatherDataUpdate(object sender, WeatherDataChangedEventArgs args);
}