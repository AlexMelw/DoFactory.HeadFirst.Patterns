namespace DoFactory.HeadFirst.State.GumballStateWinner
{
    using System;

    class GumballMachineTestDrive
    {
        static void Main(string[] args)
        {
            var machine = new GumballMachine(10);

            Console.WriteLine(machine);

            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.TurnCrank();

            Console.WriteLine(machine);

            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.TurnCrank();

            Console.WriteLine(machine);

            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.TurnCrank();

            Console.WriteLine(machine);

            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.TurnCrank();

            Console.WriteLine(machine);

            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.TurnCrank();

            Console.WriteLine(machine);

            // Wait for user
            Console.ReadKey();
        }
    }

    #region Gumball Machine

    #endregion

    #region State

    #endregion
}