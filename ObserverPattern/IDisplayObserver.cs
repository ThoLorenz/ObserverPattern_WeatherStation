namespace ObserverPattern;

public interface IDisplayObserver
{
    public void Display(float temp, float humidity, float pressure);
}