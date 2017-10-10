namespace DoFactory.HeadFirst.Compound.Composite
{
    using System;

    class DuckSimulator
    {
        static void Main(string[] args)
        {
            AbstractDuckFactory factory = new CountingDuckFactory();

            var simulator = new DuckSimulator();
            simulator.Simulate(factory);

            // Wait for user
            Console.ReadKey();
        }

        void Simulate(AbstractDuckFactory factory)
        {
            IQuackable redheadDuck = factory.CreateRedheadDuck();
            IQuackable duckCall = factory.CreateDuckCall();
            IQuackable rubberDuck = factory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("Duck Simulator: With Composite - Flocks");

            var flockOfDucks = new Flock();

            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            var flockOfMallards = new Flock();

            IQuackable mallardOne = factory.CreateMallardDuck();
            IQuackable mallardTwo = factory.CreateMallardDuck();
            IQuackable mallardThree = factory.CreateMallardDuck();
            IQuackable mallardFour = factory.CreateMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
            Simulate(flockOfDucks);

            Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
            Simulate(flockOfMallards);

            Console.WriteLine($"\nThe ducks quacked {QuackCounter.Quacks} times");
        }

        void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}