namespace DoFactory.HeadFirst.Strategy
{
    using System;

    public class LoudQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("LoudQuack");
        }
    }
}