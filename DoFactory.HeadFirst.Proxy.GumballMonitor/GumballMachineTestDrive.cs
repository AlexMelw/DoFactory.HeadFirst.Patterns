namespace DoFactory.HeadFirst.Proxy.GumballMonitor
{
    using System;

    class GumballMachineTestDrive
    {
        static void Main(string[] args)
        {
            string location = "Seattle";
            int count = 122;

            var gumballMachine = new GumballMachine(location, count);
            var monitor = new GumballMonitor(gumballMachine);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            monitor.Report();

            // Wait for user
            Console.ReadKey();
        }
    }

    #region Gumball Monitor

    #endregion

    #region Gumball Machine

    #endregion

    #region State

    #endregion
}