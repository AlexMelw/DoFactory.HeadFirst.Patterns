namespace DoFactory.HeadFirst.Composite.MenuIterator
{
    using System.Collections.Generic;

    public class Waitress
    {
        public void PrintVegetarianMenu(MenuComponent menuComponent)
        {
            IEnumerator<MenuComponent> _iterator = menuComponent.CreateIterator();

            while (_iterator.MoveNext())
            {
                MenuComponent menu = _iterator.Current;
                if (menu is Menu)
                {
                    PrintVegetarianMenu(menu);
                }
                else if (menu.Vegetarian)
                {
                    menu.Print();
                }
            }
        }
    }
}