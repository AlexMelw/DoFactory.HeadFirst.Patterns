namespace DoFactory.HeadFirst.Strategy
{
    using System;

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}