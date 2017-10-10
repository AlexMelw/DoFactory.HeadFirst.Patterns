namespace DoFactory.HeadFirst.Iterator.DinerMerger
{
    using System;

    public class Waitress
    {
        private PancakeHouseMenu _pancakeHouseMenu;
        private DinerMenu _dinerMenu;

        #region CONSTRUCTORS

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        #endregion

        public void PrintMenu()
        {
            Iterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            Iterator dinerIterator = _dinerMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);

            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        public void PrintVegetarianMenu()
        {
            PrintVegetarianMenu(_pancakeHouseMenu.CreateIterator());
            PrintVegetarianMenu(_dinerMenu.CreateIterator());
        }

        public bool IsItemVegetarian(string name)
        {
            Iterator breakfastIterator = _pancakeHouseMenu.CreateIterator();
            if (IsVegetarian(name, breakfastIterator))
            {
                return true;
            }

            Iterator dinnerIterator = _dinerMenu.CreateIterator();
            if (IsVegetarian(name, dinnerIterator))
            {
                return true;
            }
            return false;
        }

        private void PrintMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem) iterator.Next();
                Console.Write(menuItem.Name + ", ");
                Console.Write(menuItem.Price + " -- ");
                Console.WriteLine(menuItem.Description);
            }
        }

        private void PrintVegetarianMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem) iterator.Next();
                if (menuItem.Vegetarian)
                {
                    Console.WriteLine(menuItem.Name);
                    Console.WriteLine("\t\t" + menuItem.Price);
                    Console.WriteLine("\t" + menuItem.Description);
                }
            }
        }

        private bool IsVegetarian(string name, Iterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem) iterator.Next();
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