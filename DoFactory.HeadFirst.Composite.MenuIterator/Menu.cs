namespace DoFactory.HeadFirst.Composite.MenuIterator
{
    using System;
    using System.Collections.Generic;

    public class Menu : MenuComponent
    {
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }

        public override void Print()
        {
            Console.Write($"{Name}, {Description}");

            Console.WriteLine("---------------------");

            foreach (MenuComponent mc in _menuComponents)
            {
                mc.Print();
            }
        }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            return _menuComponents.GetEnumerator();
        }
    }
}