namespace DoFactory.HeadFirst.Compound.Observer
{
    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }
}