namespace DoFactory.HeadFirst.Proxy.GumballMonitor
{
    using System;

    public class SoldOutState : IState
    {
        private GumballMachine _machine;

        #region CONSTRUCTORS

        public SoldOutState(GumballMachine machine)
        {
            _machine = machine;
        }

        #endregion

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override string ToString()
        {
            return "sold out";
        }
    }
}