namespace DoFactory.HeadFirst.Composite.Menu
{
    using System;
    using System.Collections.Generic;

    public class Menu : MenuComponent
    {
        private readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();

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
            Console.Write($"\n{Name}, {Description}");

            Console.WriteLine("---------------------");

            foreach (MenuComponent menu in _menuComponents)
            {
                menu.Print();
            }
        }
    }
}