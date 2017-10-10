namespace DoFactory.HeadFirst.Command.Party
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
            _hottub.SetTemperature(98);
            _hottub.Off();
        }

        public void Undo()
        {
            _hottub.On();
        }
    }
}