namespace DoFactory.HeadFirst.Command.Party
{
    public class TVOffCommand : ICommand
    {
        private TV _tv;

        #region CONSTRUCTORS

        public TVOffCommand(TV tv)
        {
            _tv = tv;
        }

        #endregion

        public void Execute()
        {
            _tv.Off();
        }

        public void Undo()
        {
            _tv.On();
        }
    }
}