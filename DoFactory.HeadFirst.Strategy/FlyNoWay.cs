namespace DoFactory.HeadFirst.Strategy
{
    using System;

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}