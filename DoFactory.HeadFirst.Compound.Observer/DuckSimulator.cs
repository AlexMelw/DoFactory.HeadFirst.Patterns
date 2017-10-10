namespace DoFactory.HeadFirst.Compound.Observer
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
            IQuackable redheadDuck = factory.CreateRedheadDuck();
            IQuackable duckCall = factory.CreateDuckCall();
            IQuackable rubberDuck = factory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

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

            Console.WriteLine("Duck Simulator: With Observer");

            var quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);

            Simulate(flockOfDucks);

            Console.WriteLine("\nThe ducks quacked " +
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

    #region Observer

    #endregion

    #region Flock 

    #endregion

    #region Ducks

    #endregion

    #region Goose

    #endregion
}