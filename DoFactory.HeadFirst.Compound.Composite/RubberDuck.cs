namespace DoFactory.HeadFirst.Compound.Composite
{
    using System;

    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }

        public override string ToString()
        {
            return "Rubber Duck";
        }
    }
}