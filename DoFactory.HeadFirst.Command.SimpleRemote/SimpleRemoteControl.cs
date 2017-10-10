namespace DoFactory.HeadFirst.Command.SimpleRemote
{
    public class SimpleRemoteControl
    {
        private ICommand _slot;

        public ICommand Command
        {
            set { _slot = value; }
        }

        #region CONSTRUCTORS

        public SimpleRemoteControl() { }

        #endregion

        public void ButtonWasPressed()
        {
            _slot.Execute();
        }
    }
}