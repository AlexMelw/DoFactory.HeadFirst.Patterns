namespace DoFactory.HeadFirst.Iterator.DinerMerger
{
    using System;

    class MenuTestDrive
    {
        static void Main(string[] args)
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();

            var waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            waitress.PrintMenu();

            // Wait for user
            Console.ReadKey();
        }
    }

    #region Waitress

    #endregion

    #region Iterators

    #endregion

    #region Menu and MenuItems

    #endregion
}