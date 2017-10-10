namespace DoFactory.HeadFirst.Compound.Observer
{
    using System.Collections.Generic;

    public class Flock : IQuackable
    {
        private List<IQuackable> _ducks = new List<IQuackable>();

        public void Quack()
        {
            foreach (IQuackable duck in _ducks)
            {
                duck.Quack();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            foreach (IQuackable duck in _ducks)
            {
                duck.RegisterObserver(observer);
            }
        }

        public void NotifyObservers() { }

        public void Add(IQuackable duck)
        {
            _ducks.Add(duck);
        }

        public override string ToString()
        {
            return "Flock of Ducks";
        }
    }
}