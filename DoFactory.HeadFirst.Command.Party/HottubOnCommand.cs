namespace DoFactory.HeadFirst.Command.Party
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
            _hottub.SetTemperature(104);
            _hottub.Circulate();
        }

        public void Undo()
        {
            _hottub.Off();
        }
    }
}