namespace DoFactory.HeadFirst.Observer.Swing
{
    using System;

    abstract class Control
    {
        protected string text;

        #region CONSTRUCTORS

        // Constructor
        public Control(string text)
        {
            this.text = text;
        }

        #endregion

        // Event
        public event EventHandler<ClickEventArgs> Click;

        // Invoke the Click  event
        public virtual void OnClick(ClickEventArgs e)
        {
            if (Click != null)
            {
                Click(this, e);
            }
        }

        public void Attach(ActionListener listener)
        {
            Click += listener.Update;
        }

        public void Detach(ActionListener listener)
        {
            Click -= listener.Update;
        }

        // Use this method to simulate push (click) events
        public void Push(int x, int y)
        {
            OnClick(new ClickEventArgs(x, y));
            Console.WriteLine("");
        }
    }
}