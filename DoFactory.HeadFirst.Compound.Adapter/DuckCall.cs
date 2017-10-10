namespace DoFactory.HeadFirst.Compound.Adapter
{
    using System;

    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
        }
    }
}