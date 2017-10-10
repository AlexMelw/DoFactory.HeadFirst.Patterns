namespace DoFactory.HeadFirst.Compound.Ducks
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

            Console.WriteLine("Duck Simulator");

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
        }

        void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }

    #region Duck

    #endregion
}