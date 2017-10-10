namespace DoFactory.HeadFirst.Proxy.GumballMonitor
{
    using System;

    public class NoQuarterState : IState
    {
        private GumballMachine _machine;

        #region CONSTRUCTORS

        public NoQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }

        #endregion

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _machine.State = _machine.GetHasQuarterState();
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