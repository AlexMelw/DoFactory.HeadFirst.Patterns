namespace DoFactory.HeadFirst.State.GumballStateWinner
{
    using System;

    public class SoldState : IState
    {
        private GumballMachine _machine;

        #region CONSTRUCTORS

        public SoldState(GumballMachine machine)
        {
            _machine = machine;
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
            _machine.ReleaseBall();
            if (_machine.Count > 0)
            {
                _machine.State = _machine.GetNoQuarterState();
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                _machine.State = _machine.GetSoldOutState();
            }
        }

        public override string ToString()
        {
            return "dispensing a gumball";
        }
    }
}