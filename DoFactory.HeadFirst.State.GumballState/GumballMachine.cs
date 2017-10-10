namespace DoFactory.HeadFirst.State.GumballState
{
    using System;
    using System.Text;

    public class GumballMachine
    {
        private IState _soldOutState;
        private IState _noQuarterState;
        private IState _hasQuarterState;
        private IState _soldState;

        public IState State { get; set; }
        public int Count { get; private set; }

        public IState SoldOutState
        {
            get { return _soldOutState; }
        }

        public IState NoQuarterState
        {
            get { return _noQuarterState; }
        }

        public IState HasQuarterState
        {
            get { return _hasQuarterState; }
        }

        public IState SoldState
        {
            get { return _soldState; }
        }

        #region CONSTRUCTORS

        // Constructor
        public GumballMachine(int count)
        {
            Count = count;

            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);

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
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
                Count--;
        }

        public void Refill(int count)
        {
            Count = count;
            State = _noQuarterState;
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
    }
}