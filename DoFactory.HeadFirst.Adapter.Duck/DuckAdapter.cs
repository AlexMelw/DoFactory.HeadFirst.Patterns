namespace DoFactory.HeadFirst.Adapter.Duck
{
    using System;

    public class DuckAdapter : ITurkey
    {
        private IDuck _duck;
        private Random _random = new Random();

        #region CONSTRUCTORS

        // Constructor
        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
        }

        #endregion

        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly()
        {
            if (_random.Next(5) == 0)
            {
                _duck.Fly();
            }
        }
    }
}