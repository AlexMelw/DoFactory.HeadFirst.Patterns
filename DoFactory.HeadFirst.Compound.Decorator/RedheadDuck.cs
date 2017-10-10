namespace DoFactory.HeadFirst.Compound.Decorator
{
    using System;

    public class RedheadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}