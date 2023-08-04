class Program
{
    public static void Main()
    {
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
        StatisticDisplay statisticDisplay = new StatisticDisplay();
        ForcastDisplay forcastDisplay = new ForcastDisplay();

        // Subscribe: add display element at runtime
        weatherData.WeatherDataChangedEvent += currentConditionsDisplay.OnWeatherDataUpdate;
        weatherData.WeatherDataChangedEvent += statisticDisplay.OnWeatherDataUpdate;
        weatherData.WeatherDataChangedEvent += forcastDisplay.OnWeatherDataUpdate;

        weatherData.SetWeatherData(80, 65, 30.4f);
        weatherData.SetWeatherData(82, 70, 29.2f);
        weatherData.SetWeatherData(78, 90, 29.2f);

        // Unsubscribe: remove display element at runtime
        weatherData.WeatherDataChangedEvent -= currentConditionsDisplay.OnWeatherDataUpdate;
        weatherData.WeatherDataChangedEvent -= statisticDisplay.OnWeatherDataUpdate;
        weatherData.SetWeatherData(102, 66, 10.0f);

    }
}
