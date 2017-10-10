namespace DoFactory.HeadFirst.Adapter.Duck
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey _turkey;

        #region CONSTRUCTORS

        // Constructor
        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        #endregion

        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }
    }
}