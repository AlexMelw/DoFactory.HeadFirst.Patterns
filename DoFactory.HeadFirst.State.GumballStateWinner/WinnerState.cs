namespace DoFactory.HeadFirst.State.GumballStateWinner
{
    using System;

    public class WinnerState : IState
    {
        private GumballMachine _machine;

        #region CONSTRUCTORS

        public WinnerState(GumballMachine machine)
        {
            _machine = machine;
        }

        #endregion

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning again doesn't get you another gumball!");
        }

        public void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER! You get two gumballs for your quarter");
            _machine.ReleaseBall();
            if (_machine.Count == 0)
            {
                _machine.State = _machine.GetSoldOutState();
            }
            else
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
        }

        public override string ToString()
        {
            return "despensing two gumballs for your quarter, because YOU'RE A WINNER!";
        }
    }
}