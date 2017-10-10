namespace DoFactory.HeadFirst.Strategy
{
    using System;

    public class ModelDuck : Duck
    {
        #region CONSTRUCTORS

        public ModelDuck()
        {
            QuackBehavior = new LoudQuack();
            FlyBehavior = new FlyNoWay();
        }

        #endregion

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}