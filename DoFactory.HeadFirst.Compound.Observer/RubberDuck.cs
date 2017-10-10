namespace DoFactory.HeadFirst.Compound.Observer
{
    using System;

    public class RubberDuck : IQuackable
    {
        private Observable _observable;

        #region CONSTRUCTORS

        public RubberDuck()
        {
            _observable = new Observable(this);
        }

        #endregion

        public void Quack()
        {
            Console.WriteLine("Squeak");
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
            return "Rubber Duck";
        }
    }
}