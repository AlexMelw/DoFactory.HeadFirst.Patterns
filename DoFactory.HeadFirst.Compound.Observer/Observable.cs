namespace DoFactory.HeadFirst.Compound.Observer
{
    using System.Collections.Generic;

    public class Observable : IQuackObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        private IQuackObservable _duck;

        #region CONSTRUCTORS

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        #endregion

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_duck);
            }
        }
    }
}