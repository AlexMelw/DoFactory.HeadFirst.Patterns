namespace DoFactory.HeadFirst.Command.Remote
{
    using System;

    public class CeilingFan
    {
        public static readonly int HIGH = 2;
        public static readonly int MEDIUM = 1;
        public static readonly int LOW = 0;
        private string _location = "";
        private int _level;

        #region CONSTRUCTORS

        public CeilingFan(string location)
        {
            _location = location;
        }

        #endregion

        public void High()
        {
            // turns the ceiling fan on to high
            _level = HIGH;
            Console.WriteLine(_location + " ceiling fan is on high");
        }

        public void Medium()
        {
            // turns the ceiling fan on to medium
            _level = MEDIUM;
            Console.WriteLine(_location + " ceiling fan is on medium");
        }

        public void Low()
        {
            // turns the ceiling fan on to low
            _level = LOW;
            Console.WriteLine(_location + " ceiling fan is on low");
        }

        public void Off()
        {
            // turns the ceiling fan off
            _level = 0;
            Console.WriteLine(_location + " ceiling fan is off");
        }

        public int getSpeed()
        {
            return _level;
        }
    }
}