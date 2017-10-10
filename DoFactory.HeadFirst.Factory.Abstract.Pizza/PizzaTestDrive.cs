namespace DoFactory.HeadFirst.Factory.Abstract.Pizza
{
    using System;

    // PizzaTestDrive test application
    class PizzaTestDrive
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NewYorkPizzaStore();
            PizzaStore chStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.Name + "\n");

            pizza = chStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.Name + "\n");

            pizza = nyStore.OrderPizza("clam");
            Console.WriteLine("Ethan ordered a " + pizza.Name + "\n");

            pizza = chStore.OrderPizza("clam");
            Console.WriteLine("Joel ordered a " + pizza.Name + "\n");

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine("Ethan ordered a " + pizza.Name + "\n");

            pizza = chStore.OrderPizza("pepperoni");
            Console.WriteLine("Joel ordered a " + pizza.Name + "\n");

            pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine("Ethan ordered a " + pizza.Name + "\n");

            pizza = chStore.OrderPizza("veggie");
            Console.WriteLine("Joel ordered a " + pizza.Name + "\n");

            // Wait for user
            Console.ReadKey();
        }
    }

    #region Ingredient Abstract Factory

    #endregion

    #region Pizza Stores

    #endregion

    #region Pizzas

    #endregion

    #region Ingredients

    #endregion
}