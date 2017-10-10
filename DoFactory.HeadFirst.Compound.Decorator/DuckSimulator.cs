namespace DoFactory.HeadFirst.Compound.Decorator
{
    using System;

    class DuckSimulator
    {
        static void Main(string[] args)
        {
            var simulator = new DuckSimulator();
            simulator.Simulate();
        }

        void Simulate()
        {
            IQuackable mallardDuck = new QuackCounter(new MallardDuck());
            IQuackable redheadDuck = new QuackCounter(new RedheadDuck());
            IQuackable duckCall = new QuackCounter(new DuckCall());
            IQuackable rubberDuck = new QuackCounter(new RubberDuck());
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("Duck Simulator: With Decorator");

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

            Console.WriteLine("The ducks quacked " +
                              QuackCounter.Quacks + " times");

            // Wait for user
            Console.ReadKey();
        }

        void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}