namespace DoFactory.HeadFirst.Compound.Ducks
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