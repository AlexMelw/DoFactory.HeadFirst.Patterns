namespace DoFactory.HeadFirst.Template.Barista
{
    using System;

    class BeverageTestDrive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMaking tea...");
            var tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            var coffee = new Coffee();
            coffee.PrepareRecipe();

            // Hooked on Template (page 292)

            Console.WriteLine("\nMaking tea...");
            var teaHook = new TeaWithHook();
            teaHook.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            var coffeeHook = new CoffeeWithHook();
            coffeeHook.PrepareRecipe();

            // Wait for user
            Console.ReadKey();
        }
    }

    #region Coffee and Tea

    #endregion

    #region Coffee and Tea with Hook

    #endregion
}