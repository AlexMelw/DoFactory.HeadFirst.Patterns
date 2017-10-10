namespace DoFactory.HeadFirst.Observer.WeatherStationObservable
{
    using System.Collections.Generic;

    public class Observable
    {
        private bool _changed;
        private List<IObserver> _observers = new List<IObserver>();

        public bool Changed
        {
            set { _changed = value; }
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}