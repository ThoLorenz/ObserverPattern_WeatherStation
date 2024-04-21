namespace ObserverPattern;

public class DataObserver : IDataObserver
{

    private readonly WeatherDataSubject _weatherDataSubject;

    public DataObserver(WeatherDataSubject subject)
    {
        _weatherDataSubject = subject;
        _weatherDataSubject.AddObserver(this);
    }

    public void RemoveFromSubject()
    {
        _weatherDataSubject.RemoveObserver(this);
    }
    
    
    public void DataChanged(float temperature, float humidity, float pressure)
    {
       Console.WriteLine("DataObserver : temp {0} , humidity {1}, pressure {2}", temperature,humidity,pressure);
    }
}