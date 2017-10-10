namespace DoFactory.HeadFirst.Compound.Ducks
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