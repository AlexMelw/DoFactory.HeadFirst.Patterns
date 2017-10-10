namespace DoFactory.HeadFirst.Compound.Factory
{
    using System;

    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
        }

        public override string ToString()
        {
            return "Duck Call";
        }
    }
}