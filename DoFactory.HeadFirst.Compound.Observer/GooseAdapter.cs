namespace DoFactory.HeadFirst.Compound.Observer
{
    public class GooseAdapter : IQuackable
    {
        private Goose _goose;
        private Observable _observable;

        #region CONSTRUCTORS

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
            _observable = new Observable(this);
        }

        #endregion

        public void Quack()
        {
            _goose.Honk();
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
            return "Goose pretending to be a Duck";
        }
    }
}