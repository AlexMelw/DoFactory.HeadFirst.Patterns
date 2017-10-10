namespace DoFactory.HeadFirst.State.GumballState
{
    using System;

    public class SoldState : IState
    {
        private GumballMachine _gumballMachine;

        #region CONSTRUCTORS

        // Constructor
        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        #endregion

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.State = _gumballMachine.NoQuarterState;
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                _gumballMachine.State = _gumballMachine.SoldOutState;
            }
        }

        public override string ToString()
        {
            return "dispensing a gumball";
        }
    }
}