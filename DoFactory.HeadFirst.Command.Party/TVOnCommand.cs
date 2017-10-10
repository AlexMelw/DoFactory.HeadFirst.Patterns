namespace DoFactory.HeadFirst.Command.Party
{
    public class TVOnCommand : ICommand
    {
        private TV _tv;

        #region CONSTRUCTORS

        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }

        #endregion

        public void Execute()
        {
            _tv.On();
            _tv.SetInputChannel();
        }

        public void Undo()
        {
            _tv.Off();
        }
    }
}