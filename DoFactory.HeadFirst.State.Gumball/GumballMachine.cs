namespace DoFactory.HeadFirst.State.Gumball
{
    using System;
    using System.Text;

    public class GumballMachine
    {
        private GumballMachineState _state = GumballMachineState.SoldOut;
        private int _count = 0;

        #region CONSTRUCTORS

        public GumballMachine(int count)
        {
            _count = count;
            if (_count > 0)
            {
                _state = GumballMachineState.NoQuarter;
            }
        }

        #endregion

        public void InsertQuarter()
        {
            if (_state == GumballMachineState.HasQuarter)
            {
                Console.WriteLine("You can't insert another quarter");
            }
            else if (_state == GumballMachineState.NoQuarter)
            {
                _state = GumballMachineState.HasQuarter;
                Console.WriteLine("You inserted a quarter");
            }
            else if (_state == GumballMachineState.SoldOut)
            {
                Console.WriteLine("You can't insert a quarter, the machine is sold out");
            }
            else if (_state == GumballMachineState.Sold)
            {
                Console.WriteLine("Please wait, we're already giving you a gumball");
            }
        }

        public void EjectQuarter()
        {
            if (_state == GumballMachineState.HasQuarter)
            {
                Console.WriteLine("Quarter returned");
                _state = GumballMachineState.NoQuarter;
            }
            else if (_state == GumballMachineState.NoQuarter)
            {
                Console.WriteLine("You haven't inserted a quarter");
            }
            else if (_state == GumballMachineState.Sold)
            {
                Console.WriteLine("Sorry, you already turned the crank");
            }
            else if (_state == GumballMachineState.SoldOut)
            {
                Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
            }
        }

        public void TurnCrank()
        {
            if (_state == GumballMachineState.Sold)
            {
                Console.WriteLine("Turning twice doesn't get you another gumball!");
            }
            else if (_state == GumballMachineState.NoQuarter)
            {
                Console.WriteLine("You turned but there's no quarter");
            }
            else if (_state == GumballMachineState.SoldOut)
            {
                Console.WriteLine("You turned, but there are no gumballs");
            }
            else if (_state == GumballMachineState.HasQuarter)
            {
                Console.WriteLine("You turned...");
                _state = GumballMachineState.Sold;
                Dispense();
            }
        }

        public void Dispense()
        {
            if (_state == GumballMachineState.Sold)
            {
                Console.WriteLine("A gumball comes rolling out the slot");
                _count = _count - 1;
                if (_count == 0)
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _state = GumballMachineState.SoldOut;
                }
                else
                {
                    _state = GumballMachineState.NoQuarter;
                }
            }
            else if (_state == GumballMachineState.NoQuarter)
            {
                Console.WriteLine("You need to pay first");
            }
            else if (_state == GumballMachineState.SoldOut)
            {
                Console.WriteLine("No gumball dispensed");
            }
            else if (_state == GumballMachineState.HasQuarter)
            {
                Console.WriteLine("No gumball dispensed");
            }
        }

        public void Refill(int numGumBalls)
        {
            _count = numGumBalls;
            _state = GumballMachineState.NoQuarter;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nJava-enabled Standing Gumball Model #2004\n");
            result.Append("Inventory: " + _count + " gumball");

            if (_count != 1)
            {
                result.Append("s");
            }
            result.Append("\nMachine is ");
            if (_state == GumballMachineState.SoldOut)
            {
                result.Append("sold out");
            }
            else if (_state == GumballMachineState.NoQuarter)
            {
                result.Append("waiting for quarter");
            }
            else if (_state == GumballMachineState.HasQuarter)
            {
                result.Append("waiting for turn of crank");
            }
            else if (_state == GumballMachineState.Sold)
            {
                result.Append("delivering a gumball");
            }
            result.Append("\n");
            return result.ToString();
        }
    }
}