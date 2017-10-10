namespace DoFactory.HeadFirst.Decorator.Starbuzz
{
    public class Milk : CondimentDecorator
    {
        private Beverage _beverage;

        public override string Description
        {
            get { return _beverage.Description + ", Milk"; }
        }

        public override double Cost
        {
            get { return .10 + _beverage.Cost; }
        }

        #region CONSTRUCTORS

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        #endregion
    }
}