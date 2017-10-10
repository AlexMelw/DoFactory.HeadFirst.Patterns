namespace DoFactory.HeadFirst.State.GumballState
{
    using System;

    class GumballMachineTestDrive
    {
        static void Main(string[] args)
        {
            var gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            // Wait for user
            Console.ReadKey();
        }
    }

    #region Gumball Machine

    #endregion

    #region State

    #endregion
}