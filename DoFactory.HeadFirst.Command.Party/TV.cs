namespace DoFactory.HeadFirst.Command.Party
{
    using System;

    public class TV
    {
        private string _location;
        private int _channel;

        #region CONSTRUCTORS

        public TV(string location)
        {
            _location = location;
        }

        #endregion

        public void On()
        {
            Console.WriteLine(_location + " TV is on");
        }

        public void Off()
        {
            Console.WriteLine(_location + " TV is off");
        }

        public void SetInputChannel()
        {
            _channel = 3;
            Console.WriteLine(_location + " TV channel " + _channel + " is set for DVD");
        }
    }
}