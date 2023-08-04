public class ForcastDisplay : IObserver, IDisplayElement
{

    private WeatherData _weatherData;
    private float _prevPressue = 29.2f;
    private float _pressue = 0.0f;

    public ForcastDisplay(WeatherData weatherData)
    {
        this._weatherData = weatherData;
        weatherData.Subscribe(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        this._pressue = pressure;
        Display();
        this._prevPressue = pressure;
    }

    public void KnockKnock()
    {
        float pressure = this._weatherData.GetPressure();
        this._pressue = pressure;
        Display();
        this._prevPressue = pressure;
    }

    public void Display()
    {
        if (this._pressue > this._prevPressue)
        {
            Console.WriteLine($"Forcast: Improving weather on the way!");
        }
        else if (this._pressue < this._prevPressue)
        {
            Console.WriteLine($"Forcast: Watch out for cooler, rainy weather");
        }
        else // _pressure == _prePressure
        {
            Console.WriteLine($"Forcast: More of the same");
        }

    }

}