namespace DoFactory.HeadFirst.Iterator.DinerMerger
{
    using System;

    public class DinerMenu : Menu
    {
        private static readonly int MAX_ITEMS = 6;
        private int _numberOfItems = 0;
        private MenuItem[] _menuItems = new MenuItem[MAX_ITEMS];

        #region CONSTRUCTORS

        public DinerMenu()
        {
            AddItem("Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT",
                "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day",
                "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hotdog",
                "A hot dog, with saurkraut, relish, onions, topped with cheese",
                false, 3.05);
            AddItem("Steamed Veggies and Brown Rice",
                "Steamed vegetables over brown rice", true, 3.99);
            AddItem("Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true, 3.89);
        }

        #endregion

        public Iterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }

        public void AddItem(string name, string description,
            bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (_numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full!  Can't add item to menu");
            }
            else
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems = _numberOfItems + 1;
            }
        }

        public MenuItem[] GetMenuItems()
        {
            return _menuItems;
        }

        // other menu methods here
    }
}