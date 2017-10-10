namespace DoFactory.HeadFirst.Proxy.GumballState.Client
{
    using System;
    using Service_References.GumballProxy;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please wait. This may take a few moments...");

            // Create proxy object
            var proxy = new GumballMachineClient();

            proxy.StartWithQuarters(5);
            proxy.InsertQuarter();
            proxy.TurnCrank();

            Console.WriteLine(proxy.GetReport());

            proxy.InsertQuarter();
            proxy.EjectQuarter();
            proxy.TurnCrank();

            Console.WriteLine(proxy.GetReport());

            proxy.InsertQuarter();
            proxy.TurnCrank();
            proxy.InsertQuarter();
            proxy.TurnCrank();
            proxy.EjectQuarter();

            Console.WriteLine(proxy.GetReport());

            proxy.InsertQuarter();
            proxy.InsertQuarter();
            proxy.TurnCrank();
            proxy.InsertQuarter();
            proxy.TurnCrank();
            proxy.InsertQuarter();
            proxy.TurnCrank();

            Console.WriteLine(proxy.GetReport());

            // Wait for user
            Console.ReadKey();
        }
    }
}