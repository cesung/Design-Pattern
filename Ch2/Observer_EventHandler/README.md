# Design Pattern - Ch2: The Obeserver Pattern

---

## The Obeserver Pattern

Observer Pattern = Publisher (**_SUBJECT_**) + Subscribers (**_OBSERVERS_**)

> **_The Observer Pattern: defines a one-to-many dependency between objects so that when one object changes state, all of is depdendents are tofified and updated automatically._**

Observer Pattern is an example of loose coupling ⇒ We can add new/remove observers at any time, and no need to modify the subject

> **_Design Principle #4: Strive for loosely coupled designs between objects that interact_**

Note: Observer Pattern is different from Publish-Subscribe Pattern, which is a more complex pattern that allows subscribers to

1. Express interest in different types of messages and
2. Further sepeartes publichsers form subscribers

## Note

:notebook_with_decorative_cover: [Design Pattern - Ch2: Observer Pattern](https://zealous-open-f6a.notion.site/Design-Pattern-Ch2-The-Observer-41c5e83d73e6490b8996a24abcc6501a?pvs=4)

### **Original Design**

Whenever the `setWeatherData` get called, update `currentConditionsDisplay` , `statisticsDisplay`, and `forecastDisplay`

```csharp
public class WeatherData
{
    public void SetWeatherData(float temperature, float humidity, float pressure)
    {
        currentConditionsDisplay.Update(temperature, humidity, pressure);
        statisticsDisplay.Update(temperature, humidity, pressure);
        forecastDisplay.Update(temperature, humidity, pressure);
    }
}
```

```csharp
public class CurrentConditionsDisplay
{
    public void Update(float temperature, float humidity, float pressure)
    {
        // Update temperature, humidity
    }

    public void Display()
    {
        // Display current temperature and humidity
    }
}
```

```csharp
public class StatisticsDisplay
{
    public void Update(float temperature, float humidity, float pressure)
    {
        // Update temperature
    }

    public void Display()
    {
        // Display maxTemperature, minTemperature, avgTemperature
    }
}
```

```csharp
public class ForecastDisplay
{
    public void Update(float temperature, float humidity, float pressure)
    {
        // Update pressure
    }

    public void Display()
    {
        // Forcast pressure
    }
}
```

**What are the problem?**

-   We have no way to add/remove other displays without modifying `setWeatherData` function
-   No way to add/remove display element at run time

### Solution: Creating two interfaces, one for subject and one for observers

#### DisplayElement

_DisplayElement interface_

```csharp
public interface IDisplayElement
{
    void Display();
}
```

#### Subject

_Subject Interface_

```csharp
public interface ISubject
{
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
    void Notify();
}
```

_Concrete Subject class_

```csharp
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
            observer.Update(this._temperature, this._humidity, this._pressure);
        }
    }

    public void SetWeatherData(float temperature, float humidity, float pressure)
    {
        this._temperature = temperature;
        this._humidity = humidity;
        this._pressure = pressure;
        Notify();
    }
}
```

#### Observers

_Observer Interface_

```csharp
public interface IObserver
{
    void Update(float temperature, float humidity, float pressure);
}
```

_Concrete Observer classes_

```csharp
public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        weatherData.Subscribe(this);
    }

    public void Update(float temperature, float humidity, float pressue)
    {
        this._temperature = temperature;
        this._humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"{this._temperature}F degree, and {this._humidity}% humidity");
    }
}
```

```csharp
public class StatisticDisplay : IObserver, IDisplayElement
{
    const float INF = float.MaxValue;
    private float _maxTemperature = -INF;
    private float _minTemperature = INF;
    private List<float> _temperatures = new List<float>();
    private float _avgTemperature = 0;

    public StatisticDisplay(WeatherData weatherData)
    {
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

    public void Display()
    {
        Console.WriteLine($"Avg/Max/Min temperature {this._avgTemperature}/{this._maxTemperature}/{this._minTemperature}");
    }

}
```

```csharp
public class ForcastDisplay : IObserver, IDisplayElement
{
    private float _prevPressue = 29.2f;
    private float _pressue = 0.0f;

    public ForcastDisplay(WeatherData weatherData)
    {
        weatherData.Subscribe(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
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
```

### C# Syntax Sugar: Using EventHandler

#### DisplayElement

```csharp
public interface IDisplayElement
{
    void Display();
}
```

#### Subject

_Subject interface_

```csharp
public interface ISubject
{
    // void Subscribe();
    // void Unsubscribe();
    void Notify();
}
```

_Concrete Subject class_

```csharp
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
        this._temperature = temperature;
        this._humidity = humidity;
        this._pressure = pressure;
        Notify();
    }

}
```

#### Observers

_Observer interface_

```csharp
public interface IObserver
{
    void OnWeatherDataUpdate(object sender, WeatherDataChangedEventArgs args);
}
```

_Concrete Observer classes_

```csharp
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
```

```csharp
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
```

```csharp
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
```

### Don’t be that psuhy! Using public getter function

_Update the Observer interface_

```csharp
public interface IObserver
{
    void Update(float temperature, float humidity, float pressure);

    // Adding this line
    void KnockKnock();
}
```

_Modify the Notify function in `WeatherData` class_

```csharp
public void Notify()
{
    // Notify when weather data update
    foreach (IObserver observer in this._observers)
    {
        // observer.Update(this._temperature, this._humidity, this._pressure);
        observer.KnockKnock();
    }
}
```

_Expose public getter functions in `WeatherData` class_

```csharp
public class WeatherData : ISubject
{
    // ... other WeatherData functions

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
}
```

## The Big Picture

![Imgur](https://i.imgur.com/wErecvu.png)
