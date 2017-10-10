namespace DoFactory.HeadFirst.Compound.Observer
{
    using System;

    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine("Quackologist: " + duck + " just quacked.");
        }

        public override string ToString()
        {
            return "Quackologist";
        }
    }
}