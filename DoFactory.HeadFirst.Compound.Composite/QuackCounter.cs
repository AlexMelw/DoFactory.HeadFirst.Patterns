namespace DoFactory.HeadFirst.Compound.Composite
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

        public override string ToString() => _duck.ToString();
    }
}