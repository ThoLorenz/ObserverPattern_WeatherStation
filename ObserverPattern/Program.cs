using ObserverPattern;

WeatherDataSubject subject = new WeatherDataSubject();
subject.WeatherDataChanged();

Console.WriteLine("-------------");
DataObserver dataObserver = new DataObserver(subject);
DisplayObserver displayObserver = new DisplayObserver(subject);
subject.WeatherDataChanged();
Console.WriteLine("__________________________");
dataObserver.RemoveFromSubject();

subject.WeatherDataChanged();
Console.WriteLine("__________________________");

displayObserver.RemoveFromSubject();

subject.WeatherDataChanged();
Console.WriteLine("__________________________");
