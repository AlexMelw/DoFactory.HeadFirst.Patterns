namespace DoFactory.HeadFirst.Compound.Factory
{
    using System;

    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public override string ToString()
        {
            return "Mallard Duck";
        }
    }
}