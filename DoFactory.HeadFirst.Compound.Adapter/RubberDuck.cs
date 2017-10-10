namespace DoFactory.HeadFirst.Compound.Adapter
{
    using System;

    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}