namespace DoFactory.HeadFirst.Combined.MVC
{
    using System;

    /// <summary>
    ///     BeatEventArgs carry info about BPM (Beats Per Minute).
    /// </summary>
    public class BeatEventArgs : EventArgs
    {
        private int _beatsPerMinute;

        public int BeatsPerMinute
        {
            get { return _beatsPerMinute; }
        }

        #region CONSTRUCTORS

        public BeatEventArgs(int beatsPerMinute)
        {
            _beatsPerMinute = beatsPerMinute;
        }

        #endregion
    }
}