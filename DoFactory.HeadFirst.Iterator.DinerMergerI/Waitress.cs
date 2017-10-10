namespace DoFactory.HeadFirst.Iterator.DinerMergerI
{
    using System;
    using System.Collections;

    public class Waitress
    {
        private Menu _pancakeHouseMenu;
        private Menu _dinerMenu;

        #region CONSTRUCTORS

        public Waitress(Menu pancakeHouseMenu, Menu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        #endregion

        public void PrintMenu()
        {
            IEnumerator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            IEnumerator dinerIterator = _dinerMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);

            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        public void PrintVegetarianMenu()
        {
            Console.WriteLine("\nVEGETARIAN MENU\n----\nBREAKFAST");
            PrintVegetarianMenu(_pancakeHouseMenu.CreateIterator());
            Console.WriteLine("\nLUNCH");
            PrintVegetarianMenu(_dinerMenu.CreateIterator());
        }

        public bool IsItemVegetarian(string name)
        {
            IEnumerator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            if (IsVegetarian(name, pancakeIterator))
            {
                return true;
            }

            IEnumerator dinerIterator = _dinerMenu.CreateIterator();
            if (IsVegetarian(name, dinerIterator))
            {
                return true;
            }
            return false;
        }

        private void PrintMenu(IEnumerator iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = (MenuItem) iterator.Current;
                Console.Write(menuItem.Name + ", ");
                Console.Write(menuItem.Price + " -- ");
                Console.WriteLine(menuItem.Description);
            }
        }

        private void PrintVegetarianMenu(IEnumerator iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = (MenuItem) iterator.Current;
                if (menuItem.Vegetarian)
                {
                    Console.Write(menuItem.Name + ", ");
                    Console.Write(menuItem.Price + " -- ");
                    Console.WriteLine(menuItem.Description);
                }
            }
        }

        private bool IsVegetarian(string name, IEnumerator iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = (MenuItem) iterator.Current;
                if (menuItem.Name.Equals(name))
                {
                    if (menuItem.Vegetarian)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}