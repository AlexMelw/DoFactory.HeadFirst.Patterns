namespace DoFactory.HeadFirst.Iterator.DinerMergerI
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
            waitress.PrintVegetarianMenu();

            Console.WriteLine("\nCustomer asks, is the Hotdog vegetarian?");
            Console.Write("Waitress says: ");
            if (waitress.IsItemVegetarian("Hotdog"))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine("\nCustomer asks, are the Waffles vegetarian?");
            Console.Write("Waitress says: ");
            if (waitress.IsItemVegetarian("Waffles"))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    #region Waitress

    #endregion

    #region Iterators (Enumerators)

    #endregion

    #region Menu and MenuItems

    #endregion
}