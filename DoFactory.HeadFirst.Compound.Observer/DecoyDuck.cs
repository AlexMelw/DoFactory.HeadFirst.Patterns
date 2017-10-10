namespace DoFactory.HeadFirst.Compound.Observer
{
    using System;

    public class DecoyDuck : IQuackable
    {
        private Observable _observable;

        #region CONSTRUCTORS

        public DecoyDuck()
        {
            _observable = new Observable(this);
        }

        #endregion

        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
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
            return "Decoy Duck";
        }
    }
}