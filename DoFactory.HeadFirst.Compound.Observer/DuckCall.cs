namespace DoFactory.HeadFirst.Compound.Observer
{
    using System;

    public class DuckCall : IQuackable
    {
        private Observable _observable;

        #region CONSTRUCTORS

        public DuckCall()
        {
            _observable = new Observable(this);
        }

        #endregion

        public void Quack()
        {
            Console.WriteLine("Kwak");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public override string ToString()
        {
            return "Duck Call";
        }
    }
}