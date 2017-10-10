namespace DoFactory.HeadFirst.Compound.Adapter
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