namespace DoFactory.HeadFirst.Compound.Ducks
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