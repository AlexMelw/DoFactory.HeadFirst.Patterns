namespace DoFactory.HeadFirst.Command.Remote
{
    using System;

    public class Stereo
    {
        private string _location;

        #region CONSTRUCTORS

        public Stereo(string location)
        {
            _location = location;
        }

        #endregion

        public void On()
        {
            Console.WriteLine(_location + " stereo is on");
        }

        public void Off()
        {
            Console.WriteLine(_location + " stereo is off");
        }

        public void SetCD()
        {
            Console.WriteLine(_location + " stereo is set for CD input");
        }

        public void SetDVD()
        {
            Console.WriteLine(_location + " stereo is set for DVD input");
        }

        public void SetRadio()
        {
            Console.WriteLine(_location + " stereo is set for Radio");
        }

        public void SetVolume(int volume)
        {
            // Code to set the volume
            // Valid range: 1-11 (after all 11 is better than 10, right?)
            Console.WriteLine(_location + " Stereo volume set to " + volume);
        }
    }
}