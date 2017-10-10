namespace DoFactory.HeadFirst.Compound.Adapter
{
    using System;

    class DuckSimulator
    {
        static void Main(string[] args)
        {
            var simulator = new DuckSimulator();
            simulator.Simulate();

            // Wait for user
            Console.ReadKey();
        }

        void Simulate()
        {
            IQuackable mallardDuck = new MallardDuck();
            IQuackable redheadDuck = new RedheadDuck();
            IQuackable duckCall = new DuckCall();
            IQuackable rubberDuck = new RubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("Duck Simulator: With Goose Adapter");

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);
        }

        void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }

    #region Ducks

    #endregion

    #region Goose

    #endregion
}