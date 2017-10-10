namespace DoFactory.HeadFirst.Command.Remote
{
    using System;

    public class GarageDoor
    {
        private string _location;

        #region CONSTRUCTORS

        public GarageDoor(string location)
        {
            _location = location;
        }

        #endregion

        public void up()
        {
            Console.WriteLine(_location + " garage Door is Up");
        }

        public void down()
        {
            Console.WriteLine(_location + " garage Door is Down");
        }

        public void stop()
        {
            Console.WriteLine(_location + " garage Door is Stopped");
        }

        public void lightOn()
        {
            Console.WriteLine(_location + " garage light is on");
        }

        public void lightOff()
        {
            Console.WriteLine(_location + " garage light is off");
        }
    }
}