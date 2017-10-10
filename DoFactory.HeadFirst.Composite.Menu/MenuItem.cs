namespace DoFactory.HeadFirst.Composite.Menu
{
    using System;

    public class MenuItem : MenuComponent
    {
        public override void Print()
        {
            Console.Write(Name);

            if (Vegetarian)
            {
                Console.Write("(v)");
            }

            Console.WriteLine($", {Price}\n -- {Description}");
        }
    }
}