public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private WeatherData _weatherData;
    private float _temperature;
    private float _humidity;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        this._weatherData = weatherData;
        weatherData.Subscribe(this);
    }

    public void Update(float temperature, float humidity, float pressue)
    {
        this._temperature = temperature;
        this._humidity = humidity;
        Display();
    }

    public void KnockKnock()
    {
        this._temperature = this._weatherData.GetTemperature();
        this._humidity = this._weatherData.GetHumidity();
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"{this._temperature}F degree, and {this._humidity}% humidity");
    }
}