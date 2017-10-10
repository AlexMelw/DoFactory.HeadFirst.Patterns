namespace DoFactory.HeadFirst.Compound.Adapter
{
    using System;

    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}