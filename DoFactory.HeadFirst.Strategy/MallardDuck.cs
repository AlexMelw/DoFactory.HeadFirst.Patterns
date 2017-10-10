namespace DoFactory.HeadFirst.Strategy
{
    using System;

    public class MallardDuck : Duck
    {
        #region CONSTRUCTORS

        public MallardDuck()
        {
            QuackBehavior = new LoudQuack();
            FlyBehavior = new FlyWithWings();
        }

        #endregion

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}