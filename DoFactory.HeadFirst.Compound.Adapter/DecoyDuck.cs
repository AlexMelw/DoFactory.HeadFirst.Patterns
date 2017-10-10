namespace DoFactory.HeadFirst.Compound.Adapter
{
    using System;

    public class DecoyDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}