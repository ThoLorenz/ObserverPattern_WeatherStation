using ObserverPattern;

public class WeatherDataSubject : ISubject
{
    private List<IDataObserver> _observers = new();
    private float _temperature;
    private float _pressure;
    private float _humidity;
    readonly Random _random = new();

    public void WeatherDataChanged()
    {
        _temperature = GetRandom(this._random, 20, 50);
        _humidity = GetRandom(this._random, 0, 100);
        _pressure = GetRandom(this._random, 10, 60);
        NotifyObservers();
    }


    private float GetRandom(Random random, float min, float max)
    {
        return (float)(min + (random.NextInt64() * (max - min)));
    }

    public void AddObserver(IDataObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IDataObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        _temperature = GetRandom(this._random, 20, 50);
        _humidity = GetRandom(this._random, 0, 100);
        _pressure = GetRandom(this._random, 10, 60);
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    public float GetPressure()
    {
        return this._pressure;
    }
    public float GetHumidity()
    {
        return this._humidity;
    }
    public float GetTemperature()
    {
        return this._temperature;
    }
}