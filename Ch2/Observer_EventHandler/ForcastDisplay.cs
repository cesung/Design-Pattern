public class ForcastDisplay : IObserver, IDisplayElement
{
    private float _prevPressue = 29.2f;
    private float _pressue = 0.0f;

    public void OnWeatherDataUpdate(object? sender, WeatherDataChangedEventArgs args)
    {
        this._pressue = args._pressure;
        Display();
        this._prevPressue = this._pressue;
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