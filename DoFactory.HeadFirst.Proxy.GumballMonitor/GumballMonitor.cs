namespace DoFactory.HeadFirst.Proxy.GumballMonitor
{
    using System;

    public class GumballMonitor
    {
        private GumballMachine _machine;

        #region CONSTRUCTORS

        public GumballMonitor(GumballMachine machine)
        {
            _machine = machine;
        }

        #endregion

        public void Report()
        {
            Console.WriteLine("Gumball Machine: " + _machine.Location);
            Console.WriteLine("Current inventory: " + _machine.Count + " gumballs");
            Console.WriteLine("Current state: " + _machine.State);
        }
    }
}