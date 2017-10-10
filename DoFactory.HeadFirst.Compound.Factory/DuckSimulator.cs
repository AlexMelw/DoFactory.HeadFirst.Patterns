namespace DoFactory.HeadFirst.Compound.Factory
{
    using System;

    class DuckSimulator
    {
        static void Main(string[] args)
        {
            var simulator = new DuckSimulator();
            AbstractDuckFactory factory = new CountingDuckFactory();

            simulator.Simulate(factory);

            // Wait for user
            Console.ReadKey();
        }

        void Simulate(AbstractDuckFactory factory)
        {
            IQuackable mallardDuck = factory.CreateMallardDuck();
            IQuackable redheadDuck = factory.CreateRedheadDuck();
            IQuackable duckCall = factory.CreateDuckCall();
            IQuackable rubberDuck = factory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("Duck Simulator: With Abstract Factory");

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

            Console.WriteLine("The ducks quacked " +
                              QuackCounter.Quacks + " times");
        }

        void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }

    #region Factory

    #endregion

    #region Quack Counter

    #endregion

    #region Ducks

    #endregion

    #region Goose

    #endregion
}