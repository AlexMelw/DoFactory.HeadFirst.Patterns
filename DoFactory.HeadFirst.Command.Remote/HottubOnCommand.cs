namespace DoFactory.HeadFirst.Command.Remote
{
    public class HottubOnCommand : ICommand
    {
        private Hottub _hottub;

        #region CONSTRUCTORS

        public HottubOnCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        #endregion

        public void Execute()
        {
            _hottub.On();
            _hottub.Heat();
            _hottub.BubblesOn();
        }
    }
}