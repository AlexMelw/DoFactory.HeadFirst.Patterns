namespace DoFactory.HeadFirst.Facade.HomeTheater
{
    using System;

    public class DvdPlayer
    {
        private string _description;
        private int _currentTrack;
        private Amplifier _amplifier;
        private string _movie;

        #region CONSTRUCTORS

        public DvdPlayer(string description, Amplifier amplifier)
        {
            _description = description;
            _amplifier = amplifier;
        }

        #endregion

        public void On()
        {
            Console.WriteLine(_description + " on");
        }

        public void Off()
        {
            Console.WriteLine(_description + " off");
        }

        public void Eject()
        {
            _movie = null;
            Console.WriteLine(_description + " eject");
        }

        public void Play(string movie)
        {
            _movie = movie;
            _currentTrack = 0;
            Console.WriteLine(_description + " playing \"" + movie + "\"");
        }

        public void Play(int track)
        {
            if (_movie == null)
            {
                Console.WriteLine(_description + " can't play track " + track + " no dvd inserted");
            }
            else
            {
                _currentTrack = track;
                Console.WriteLine(_description + " playing track " + _currentTrack + " of \"" + _movie + "\"");
            }
        }

        public void Stop()
        {
            _currentTrack = 0;
            Console.WriteLine(_description + " stopped \"" + _movie + "\"");
        }

        public void Pause()
        {
            Console.WriteLine(_description + " paused \"" + _movie + "\"");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine(_description + " set two channel audio");
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine(_description + " set surround audio");
        }

        public override string ToString()
        {
            return _description;
        }
    }
}