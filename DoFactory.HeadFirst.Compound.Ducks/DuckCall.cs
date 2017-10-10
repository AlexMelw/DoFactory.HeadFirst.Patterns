namespace DoFactory.HeadFirst.Compound.Ducks
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