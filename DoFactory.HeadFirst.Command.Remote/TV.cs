namespace DoFactory.HeadFirst.Command.Remote
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
            Console.WriteLine("TV is on");
        }

        public void Off()
        {
            Console.WriteLine("TV is off");
        }

        public void SetInputChannel()
        {
            _channel = 3;
            Console.WriteLine("Channel " + _channel + " is set for VCR");
        }
    }
}