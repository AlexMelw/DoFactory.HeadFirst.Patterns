namespace DoFactory.HeadFirst.Composite.Menu
{
    public class Waitress
    {
        private readonly MenuComponent _allMenus;

        #region CONSTRUCTORS

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        #endregion

        public void PrintMenu()
        {
            _allMenus.Print();
        }
    }
}