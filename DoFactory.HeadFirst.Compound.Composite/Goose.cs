namespace DoFactory.HeadFirst.Compound.Composite
{
    using System;

    public class Goose
    {
        public void Honk()
        {
            Console.WriteLine("Honk");
        }

        public override string ToString()
        {
            return "Goose";
        }
    }
}