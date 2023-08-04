public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;

    public void OnWeatherDataUpdate(object? sender, WeatherDataChangedEventArgs args)
    {
        this._temperature = args._temperature;
        this._humidity = args._humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"{this._temperature}F degree, and {this._humidity}% humidity");
    }
}