namespace DoFactory.HeadFirst.Decorator.Starbuzz
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;

        public override string Description
        {
            get { return _beverage.Description + ", Mocha"; }
        }

        public override double Cost
        {
            get { return .20 + _beverage.Cost; }
        }

        #region CONSTRUCTORS

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        #endregion
    }
}