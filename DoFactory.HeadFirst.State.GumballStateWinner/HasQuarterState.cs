namespace DoFactory.HeadFirst.State.GumballStateWinner
{
    using System;

    public class HasQuarterState : IState
    {
        private GumballMachine _machine;

        #region CONSTRUCTORS

        public HasQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }

        #endregion

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _machine.State = _machine.GetNoQuarterState();
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            Random random = new Random();

            int winner = random.Next(11);
            if (winner == 0 && _machine.Count > 1)
            {
                _machine.State = _machine.GetWinnerState();
            }
            else
            {
                _machine.State = _machine.GetSoldState();
            }
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