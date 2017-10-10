namespace DoFactory.HeadFirst.Iterator.DinerMergerCafe
{
    using System.Collections.Generic;

    public class DinerMenu : IMenu
    {
        private List<MenuItem> _menuItems = new List<MenuItem>();

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
                "A medly of steamed vegetables over brown rice", true, 3.99);
            AddItem("Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true, 3.89);
        }

        #endregion

        public IEnumerator<MenuItem> CreateIterator()
        {
            return _menuItems.GetEnumerator();
        }

        public void AddItem(string name, string description,
            bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem);
        }

        // other menu methods here
    }
}