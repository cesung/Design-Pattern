public class StatisticDisplay : IObserver, IDisplayElement
{
    const float INF = float.MaxValue;

    private WeatherData _weatherData;
    private float _maxTemperature = -INF;
    private float _minTemperature = INF;
    private List<float> _temperatures = new List<float>();
    private float _avgTemperature = 0;

    public StatisticDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.Subscribe(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        this._temperatures.Add(temperature);

        this._maxTemperature = Math.Max(
            this._maxTemperature,
            temperature
        );

        this._minTemperature = Math.Min(
            this._minTemperature,
            temperature
        );

        this._avgTemperature = this._temperatures.Sum() / this._temperatures.Count;

        Display();
    }

    public void KnockKnock()
    {
        float temperature = this._weatherData.GetTemperature();

        this._temperatures.Add(temperature);

        this._maxTemperature = Math.Max(
            this._maxTemperature,
            temperature
        );

        this._minTemperature = Math.Min(
            this._minTemperature,
            temperature
        );

        this._avgTemperature = this._temperatures.Sum() / this._temperatures.Count;

        Display();

    }

    public void Display()
    {
        Console.WriteLine($"Avg/Max/Min temperature {this._avgTemperature}/{this._maxTemperature}/{this._minTemperature}");
    }

}