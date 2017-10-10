namespace DoFactory.HeadFirst.State.GumballState
{
    using System;

    public class NoQuarterState : IState
    {
        private GumballMachine _gumballMachine;

        #region CONSTRUCTORS

        // Constructor
        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        #endregion

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.State = _gumballMachine.HasQuarterState;
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public override string ToString()
        {
            return "waiting for quarter";
        }
    }
}