namespace DoFactory.HeadFirst.Decorator.Starbuzz
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public override string Description
        {
            get { return _beverage.Description + ", Whip"; }
        }

        public override double Cost
        {
            get { return .10 + _beverage.Cost; }
        }

        #region CONSTRUCTORS

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        #endregion
    }
}