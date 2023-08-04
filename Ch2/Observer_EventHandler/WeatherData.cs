public class WeatherDataChangedEventArgs : EventArgs
{
    public float _temperature;
    public float _humidity;
    public float _pressure;

    public WeatherDataChangedEventArgs(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
    }
}

public class WeatherData : ISubject
{
    public event EventHandler<WeatherDataChangedEventArgs>? WeatherDataChangedEvent;

    private float _temperature;
    private float _humidity;
    private float _pressure;

    // public void Subscribe() { }
    // public void Unsubscribe() { }

    public void Notify()
    {
        WeatherDataChangedEvent?.Invoke
        (
            this,
            new WeatherDataChangedEventArgs
            (
                this._temperature,
                this._humidity,
                this._pressure
            )
        );
    }
    public void SetWeatherData(float temperature, float humidity, float pressure)
    {
        Console.WriteLine("--------------------");
        this._temperature = temperature;
        this._humidity = humidity;
        this._pressure = pressure;
        Notify();
    }

}
