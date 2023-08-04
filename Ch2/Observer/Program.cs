class Program
{
    public static void Main()
    {
        WeatherData weatherData = new WeatherData();

        // Subscribe
        CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
        StatisticDisplay statisticDisplay = new StatisticDisplay(weatherData);
        ForcastDisplay forcastDisplay = new ForcastDisplay(weatherData);

        weatherData.SetWeatherData(80, 65, 30.4f);
        weatherData.SetWeatherData(82, 70, 29.2f);
        weatherData.SetWeatherData(78, 90, 29.2f);

        // Unsubscribe
        weatherData.Unsubscribe(currentConditionsDisplay);
        weatherData.Unsubscribe(statisticDisplay);
        weatherData.SetWeatherData(102, 66, 10.0f);
    }
}
