namespace DoFactory.HeadFirst.Adapter.Duck
{
    using System;

    class DuckTestDrive
    {
        static void Main(string[] args)
        {
            // Test 1: Duck test drive

            var duck = new MallardDuck();
            var turkey = new WildTurkey();

            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says...");

            turkey.Gobble();
            turkey.Fly();


            Console.WriteLine("\nThe Duck says...");
            TestDuck(duck);

            Console.WriteLine("\nThe TurkeyAdapter says...");
            TestDuck(turkeyAdapter);

            // Test 2: Turkey test drive

            ITurkey duckAdapter = new DuckAdapter(duck);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The DuckAdapter says...");
                duckAdapter.Gobble();
                duckAdapter.Fly();
            }

            // Wait for user
            Console.ReadKey();
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}