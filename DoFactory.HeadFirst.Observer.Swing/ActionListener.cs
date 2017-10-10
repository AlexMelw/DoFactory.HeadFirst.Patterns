namespace DoFactory.HeadFirst.Observer.Swing
{
    using System;

    class ActionListener : IActionListener
    {
        private string _name;

        #region CONSTRUCTORS

        // Constructor
        public ActionListener(string name)
        {
            _name = name;
        }

        #endregion

        public void Update(object sender, ClickEventArgs e)
        {
            Console.WriteLine("Notified {0} of click at ({1},{2})",
                _name, e.X, e.Y);
        }
    }
}