namespace DoFactory.HeadFirst.Strategy
{
    using System;

    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}