namespace DoFactory.HeadFirst.State.GumballState
{
    using System;

    public class HasQuarterState : IState
    {
        private GumballMachine _gumballMachine;

        #region CONSTRUCTORS

        // Constructor
        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        #endregion

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.State = _gumballMachine.NoQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            _gumballMachine.State = _gumballMachine.SoldState;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override string ToString()
        {
            return "waiting for turn of crank";
        }
    }
}