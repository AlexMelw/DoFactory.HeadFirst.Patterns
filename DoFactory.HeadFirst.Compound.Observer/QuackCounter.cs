namespace DoFactory.HeadFirst.Compound.Observer
{
    public class QuackCounter : IQuackable
    {
        private IQuackable _duck;

        public static int Quacks { get; private set; }

        #region CONSTRUCTORS

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }

        #endregion

        public void Quack()
        {
            _duck.Quack();
            Quacks++;
        }

        public void RegisterObserver(IObserver observer)
        {
            _duck.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _duck.NotifyObservers();
        }

        public override string ToString()
        {
            return _duck.ToString();
        }
    }
}