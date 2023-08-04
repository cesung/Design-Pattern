public class StatisticDisplay : IObserver, IDisplayElement
{
    const float INF = float.MaxValue;
    private float _maxTemperature = -INF;
    private float _minTemperature = INF;
    private List<float> _temperatures = new List<float>();
    private float _avgTemperature = 0;

    public void OnWeatherDataUpdate(object? sender, WeatherDataChangedEventArgs args)
    {
        this._temperatures.Add(args._temperature);

        this._maxTemperature = Math.Max(
            this._maxTemperature,
            args._temperature
        );

        this._minTemperature = Math.Min(
            this._minTemperature,
            args._temperature
        );

        this._avgTemperature = this._temperatures.Sum() / this._temperatures.Count;

        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Avg/Max/Min temperature {this._avgTemperature}/{this._maxTemperature}/{this._minTemperature}");
    }

}