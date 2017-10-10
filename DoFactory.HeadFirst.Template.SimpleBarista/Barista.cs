namespace DoFactory.HeadFirst.Template.SimpleBarista
{
    using System;

    class Barista
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMaking tea...");
            var tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            var coffee = new Coffee();
            coffee.PrepareRecipe();

            // Wait for user
            Console.ReadKey();
        }
    }

    #region Coffee

    #endregion

    #region Tea

    #endregion
}