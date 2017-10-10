namespace DoFactory.HeadFirst.Compound.Ducks
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