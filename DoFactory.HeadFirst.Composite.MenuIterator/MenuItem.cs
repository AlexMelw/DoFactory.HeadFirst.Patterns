namespace DoFactory.HeadFirst.Composite.MenuIterator
{
    using System;
    using System.Collections.Generic;

    public class MenuItem : MenuComponent
    {
        public override IEnumerator<MenuComponent> CreateIterator() => null;

        public override void Print()
        {
            Console.Write($"  {Name}");

            if (Vegetarian)
            {
                Console.Write("(v)");
            }

            Console.WriteLine($", {Price}     -- {Description}");
        }
    }
}