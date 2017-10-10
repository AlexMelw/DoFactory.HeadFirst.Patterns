namespace DoFactory.HeadFirst.Proxy.GumballMonitor
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

        private IState _state;

        public int Count { get; private set; }
        public string Location { get; }

        public IState State
        {
            set { _state = value; }
            get { return _state; }
        }

        #region CONSTRUCTORS

        public GumballMachine(string location, int count)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);

            Location = location;
            Count = count;

            if (Count > 0)
                _state = _noQuarterState;
            else
                _state = _soldOutState;
        }

        #endregion

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
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
            result.Append("Machine is " + _state + "\n");
            return result.ToString();
        }

        void Refill(int count)
        {
            Count = count;
            _state = _noQuarterState;
        }
    }
}