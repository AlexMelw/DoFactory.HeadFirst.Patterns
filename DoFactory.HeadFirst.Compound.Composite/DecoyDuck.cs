namespace DoFactory.HeadFirst.Compound.Composite
{
    using System;

    public class DecoyDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }

        public override string ToString()
        {
            return "Decoy Duck";
        }
    }
}