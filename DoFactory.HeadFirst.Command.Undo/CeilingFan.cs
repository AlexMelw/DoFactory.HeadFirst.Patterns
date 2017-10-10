namespace DoFactory.HeadFirst.Command.Undo
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
            Speed = CeilingFanSpeed.Off;
        }

        #endregion

        public void High()
        {
            Speed = CeilingFanSpeed.High;
            Console.WriteLine(_location + " ceiling fan is on high");
        }

        public void Medium()
        {
            Speed = CeilingFanSpeed.Medium;
            Console.WriteLine(_location + " ceiling fan is on medium");
        }

        public void Low()
        {
            Speed = CeilingFanSpeed.Low;
            Console.WriteLine(_location + " ceiling fan is on low");
        }

        public void Off()
        {
            Speed = CeilingFanSpeed.Off;
            Console.WriteLine(_location + " ceiling fan is off");
        }
    }
}