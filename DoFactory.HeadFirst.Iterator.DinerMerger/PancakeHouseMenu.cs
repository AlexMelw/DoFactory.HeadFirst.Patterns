namespace DoFactory.HeadFirst.Iterator.DinerMerger
{
    using System.Collections;

    public class PancakeHouseMenu : Menu
    {
        private ArrayList _menuItems = new ArrayList();

        #region CONSTRUCTORS

        public PancakeHouseMenu()
        {
            AddItem("K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99);

            AddItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99);

            AddItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries",
                true,
                3.49);

            AddItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59);
        }

        #endregion

        public Iterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(_menuItems);
        }

        public void AddItem(string name, string description,
            bool vegetarian, double price)
        {
            _menuItems.Add(new MenuItem(name, description, vegetarian, price));
        }

        public ArrayList GetMenuItems()
        {
            return _menuItems;
        }

        public override string ToString()
        {
            return "Objectville Pancake House Menu";
        }

        // other menu methods here
    }
}