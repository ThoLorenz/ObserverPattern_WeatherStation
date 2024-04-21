namespace ObserverPattern;

public class DisplayObserver : IDataObserver, IDisplayObserver
{

    private readonly WeatherDataSubject _weatherDataSubject;

    public DisplayObserver(WeatherDataSubject subject)
    {
        _weatherDataSubject = subject;
        _weatherDataSubject.AddObserver(this);
    }
    
    public void RemoveFromSubject()
    {
        _weatherDataSubject.RemoveObserver(this);
    }
    
    public void DataChanged(float temp, float humidity, float pressure)
    {
        Display(temp,humidity,pressure);
    }

    public void Display(float temp, float humidity, float pressure)
    {
        Console.WriteLine("Bildschirm_Observer : temp {0} , humidity {1}, pressure {2}", temp,humidity,pressure);
    }
}