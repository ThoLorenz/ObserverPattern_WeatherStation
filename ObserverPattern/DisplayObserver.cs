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
    
    public void Update()
    {
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Bildschirm_Observer : pressure {0} "
            , _weatherDataSubject.GetPressure());
    }
}