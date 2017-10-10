namespace DoFactory.HeadFirst.Iterator.DinerMergerCafe
{
    using System.Collections.Generic;

    public class PancakeHouseMenu : IMenu
    {
        List<MenuItem> menuItems = new List<MenuItem>();

        #region CONSTRUCTORS

        public PancakeHouseMenu()
        {
            //menuItems = new ArrayList();

            AddItem("K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99);

            AddItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99);

            AddItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries, and blueberry syrup",
                true,
                3.49);

            AddItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59);
        }

        #endregion

        public IEnumerator<MenuItem> CreateIterator()
        {
            return menuItems.GetEnumerator();
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        // other menu methods here
    }
}