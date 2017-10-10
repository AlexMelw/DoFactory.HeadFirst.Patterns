namespace DoFactory.HeadFirst.State.GumballStateWinner
{
    using System;
    using System.Text;

    public class GumballMachine
    {
        private IState _soldOutState;
        private IState _noQuarterState;
        private IState _hasQuarterState;
        private IState _soldState;
        private IState _winnerState;

        public IState State { get; set; }
        public int Count { get; private set; }

        #region CONSTRUCTORS

        public GumballMachine(int count)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);

            Count = count;
            if (Count > 0)
            {
                State = _noQuarterState;
            }
            else
            {
                State = _soldOutState;
            }
        }

        #endregion

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void ReleaseBall()
        {
            if (Count > 0)
            {
                Console.WriteLine("A gumball comes rolling out the slot...");
                Count--;
            }
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public IState GetWinnerState()
        {
            return _winnerState;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\n.NET-enabled Standing Gumball Model #2004");
            result.Append("\nInventory: " + Count + " gumball");
            if (Count != 1)
            {
                result.Append("s");
            }
            result.Append("\n");
            result.Append("Machine is " + State + "\n");
            return result.ToString();
        }

        void Refill(int count)
        {
            Count = count;
            State = _noQuarterState;
        }
    }
}