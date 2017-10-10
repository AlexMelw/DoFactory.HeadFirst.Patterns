namespace DoFactory.HeadFirst.Iterator.DinerMergerCafe
{
    using System.Collections.Generic;

    public class CafeMenu : IMenu
    {
        private Dictionary<string, MenuItem> _menuItems =
            new Dictionary<string, MenuItem>();

        #region CONSTRUCTORS

        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 3.99);
            AddItem("Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false, 3.69);
            AddItem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true, 4.29);
        }

        #endregion

        public IEnumerator<MenuItem> CreateIterator()
        {
            return _menuItems.Values.GetEnumerator();
        }

        public void AddItem(string name, string description,
            bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem.Name, menuItem);
        }
    }
}