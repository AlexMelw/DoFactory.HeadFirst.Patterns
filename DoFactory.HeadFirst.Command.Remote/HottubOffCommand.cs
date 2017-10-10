namespace DoFactory.HeadFirst.Command.Remote
{
    public class HottubOffCommand : ICommand
    {
        private Hottub _hottub;

        #region CONSTRUCTORS

        public HottubOffCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        #endregion

        public void Execute()
        {
            _hottub.Cool();
            _hottub.Off();
        }
    }
}