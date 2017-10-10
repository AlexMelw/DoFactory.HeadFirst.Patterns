namespace DoFactory.HeadFirst.Iterator.DinerMerger
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Vegetarian { get; set; }

        #region CONSTRUCTORS

        // Constructor
        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }

        #endregion

        public override string ToString()
        {
            return Name + ", $" + Price + "\n   " + Description;
        }
    }
}