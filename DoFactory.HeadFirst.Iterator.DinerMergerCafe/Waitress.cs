namespace DoFactory.HeadFirst.Iterator.DinerMergerCafe
{
    using System;
    using System.Collections.Generic;

    public class Waitress
    {
        private IMenu _pancakeHouseMenu;
        private IMenu _dinerMenu;
        private IMenu _cafeMenu;

        #region CONSTRUCTORS

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
            _cafeMenu = cafeMenu;
        }

        #endregion

        public void PrintMenu()
        {
            IEnumerator<MenuItem> pancakeIterator = _pancakeHouseMenu.CreateIterator();
            IEnumerator<MenuItem> dinerIterator = _dinerMenu.CreateIterator();
            IEnumerator<MenuItem> cafeIterator = _cafeMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);

            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);

            Console.WriteLine("\nDINNER");
            PrintMenu(cafeIterator);
        }

        public void PrintVegetarianMenu()
        {
            Console.WriteLine("\nVEGETARIAN MENU\n---------------");
            PrintVegetarianMenu(_pancakeHouseMenu.CreateIterator());
            PrintVegetarianMenu(_dinerMenu.CreateIterator());
            PrintVegetarianMenu(_cafeMenu.CreateIterator());
        }

        public bool IsItemVegetarian(string name)
        {
            IEnumerator<MenuItem> pancakeIterator = _pancakeHouseMenu.CreateIterator();
            if (IsVegetarian(name, pancakeIterator))
            {
                return true;
            }
            IEnumerator<MenuItem> dinerIterator = _dinerMenu.CreateIterator();
            if (IsVegetarian(name, dinerIterator))
            {
                return true;
            }
            IEnumerator<MenuItem> cafeIterator = _cafeMenu.CreateIterator();
            if (IsVegetarian(name, cafeIterator))
            {
                return true;
            }
            return false;
        }

        private void PrintMenu(IEnumerator<MenuItem> iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = (MenuItem) iterator.Current;

                Console.Write(menuItem.Name + ", ");
                Console.Write(menuItem.Price + " -- ");
                Console.WriteLine(menuItem.Description);
            }
        }

        private void PrintVegetarianMenu(IEnumerator<MenuItem> iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = iterator.Current;
                if (menuItem.Vegetarian)
                {
                    Console.Write(menuItem.Name + ", ");
                    Console.Write(menuItem.Price + " -- ");
                    Console.WriteLine(menuItem.Description);
                }
            }
        }

        private bool IsVegetarian(string name, IEnumerator<MenuItem> iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = iterator.Current;
                if (menuItem.Name == name)
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