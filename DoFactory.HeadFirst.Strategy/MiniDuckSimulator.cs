namespace DoFactory.HeadFirst.Strategy
{
    using System;

    public class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.WriteLine("");

            Duck model = new ModelDuck();
            model.Display();
            model.PerformFly();

            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();

            // Wait for user input
            Console.ReadKey();
        }
    }

    #region Duck

    #endregion

    #region FlyBehavior

    #endregion

    #region QuackBehavior

    // Name it LoadQuack to avoid conflict with method name

    #endregion
}