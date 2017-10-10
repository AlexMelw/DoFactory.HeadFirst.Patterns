namespace DoFactory.HeadFirst.Compound.Observer
{
    using System;

    public class RedheadDuck : IQuackable
    {
        private Observable _observable;

        #region CONSTRUCTORS

        public RedheadDuck()
        {
            _observable = new Observable(this);
        }

        #endregion

        public void Quack()
        {
            Console.WriteLine("Quack");
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
            return "Redhead Duck";
        }
    }
}