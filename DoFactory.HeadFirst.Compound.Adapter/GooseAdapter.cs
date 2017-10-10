namespace DoFactory.HeadFirst.Compound.Adapter
{
    public class GooseAdapter : IQuackable
    {
        private Goose _goose;

        #region CONSTRUCTORS

        // Constructor
        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        #endregion

        public void Quack()
        {
            _goose.Honk();
        }

        public override string ToString()
        {
            return "Goose pretending to be a Duck";
        }
    }
}