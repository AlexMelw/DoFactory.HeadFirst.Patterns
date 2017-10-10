namespace DoFactory.HeadFirst.Decorator.Starbuzz
{
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;

        public override string Description
        {
            get { return _beverage.Description + ", Soy"; }
        }

        public override double Cost
        {
            get { return .15 + _beverage.Cost; }
        }

        #region CONSTRUCTORS

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        #endregion
    }
}