namespace DoFactory.HeadFirst.Observer.Swing
{
    using System;

    public class ClickEventArgs : EventArgs
    {
        public int X { get; }
        public int Y { get; }

        #region CONSTRUCTORS

        // Constructor
        public ClickEventArgs(int x, int y)
        {
            X = x;
            Y = y;
        }

        #endregion
    }
}