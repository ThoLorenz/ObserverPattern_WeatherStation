namespace ObserverPattern;

public interface ISubject
{
    public void AddObserver(IDataObserver observer);
    public void RemoveObserver(IDataObserver observer);
    public void NotifyObservers();
}