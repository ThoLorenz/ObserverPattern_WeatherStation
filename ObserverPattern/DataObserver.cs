namespace ObserverPattern;

public class DataObserver : IDataObserver
{

    private readonly WeatherDataSubject _weatherDataSubject;
    private float _humidity ;
    private float _pressure;
    private float _temperature;

    public DataObserver(WeatherDataSubject subject)
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
       Console.WriteLine("DataObserver : temp {0} , humidity {1}"
           , _weatherDataSubject.GetTemperature(), _weatherDataSubject.GetHumidity());
    }
}