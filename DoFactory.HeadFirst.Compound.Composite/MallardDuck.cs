namespace DoFactory.HeadFirst.Compound.Composite
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