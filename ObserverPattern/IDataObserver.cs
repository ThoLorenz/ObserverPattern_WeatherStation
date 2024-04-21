namespace ObserverPattern;

public interface IDataObserver
{
    public void DataChanged(float temp, float humidity, float pressure);
}