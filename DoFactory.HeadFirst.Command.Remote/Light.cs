namespace DoFactory.HeadFirst.Command.Remote
{
    using System;

    public class Light
    {
        private string _location;

        #region CONSTRUCTORS

        public Light(string location)
        {
            _location = location;
        }

        #endregion

        public void On()
        {
            Console.WriteLine(_location + " light is on");
        }

        public void Off()
        {
            Console.WriteLine(_location + " light is off");
        }
    }
}