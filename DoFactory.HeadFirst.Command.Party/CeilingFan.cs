namespace DoFactory.HeadFirst.Command.Party
{
    using System;

    public class CeilingFan
    {
        private string _location;

        public CeilingFanSpeed Speed { get; private set; }

        #region CONSTRUCTORS

        public CeilingFan(string location)
        {
            _location = location;
        }

        #endregion

        public void high()
        {
            // turns the ceiling fan on to high
            Speed = CeilingFanSpeed.High;
            Console.WriteLine(_location + " ceiling fan is on high");
        }

        public void medium()
        {
            // turns the ceiling fan on to medium
            Speed = CeilingFanSpeed.Medium;
            Console.WriteLine(_location + " ceiling fan is on medium");
        }

        public void low()
        {
            // turns the ceiling fan on to low
            Speed = CeilingFanSpeed.Low;
            Console.WriteLine(_location + " ceiling fan is on low");
        }

        public void Off()
        {
            // turns the ceiling fan off
            Speed = CeilingFanSpeed.Off;
            Console.WriteLine(_location + " ceiling fan is off");
        }
    }
}