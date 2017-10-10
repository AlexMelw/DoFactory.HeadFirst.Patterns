namespace DoFactory.HeadFirst.Compound.Composite
{
    using System;

    public class RedheadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public override string ToString()
        {
            return "Redhead Duck";
        }
    }
}