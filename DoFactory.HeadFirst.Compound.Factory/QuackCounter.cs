namespace DoFactory.HeadFirst.Compound.Factory
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

        public override string ToString()
        {
            return _duck.ToString();
        }
    }
}