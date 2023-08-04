public class WeatherData : ISubject
{
    private List<IObserver> _observers;
    private float _temperature;
    private float _humidity;
    private float _pressure;

    public WeatherData()
    {
        _observers = new List<IObserver>();
    }

    public float GetTemperature()
    {
        return this._temperature;
    }

    public float GetHumidity()
    {
        return this._humidity;
    }

    public float GetPressure()
    {
        return this._pressure;
    }

    public void Subscribe(IObserver observer)
    {
        // Do subscribe
        this._observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        // Do unsubscribe
        this._observers.Remove(observer);
    }

    public void Notify()
    {
        // Notify when weather data update
        foreach (IObserver observer in this._observers)
        {
            // observer.Update(this._temperature, this._humidity, this._pressure);
            observer.KnockKnock();
        }
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