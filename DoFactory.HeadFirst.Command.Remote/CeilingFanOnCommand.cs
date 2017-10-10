namespace DoFactory.HeadFirst.Command.Remote
{
    public class CeilingFanOnCommand : ICommand
    {
        private CeilingFan _ceilingFan;

        #region CONSTRUCTORS

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        #endregion

        public void Execute()
        {
            _ceilingFan.High();
        }
    }
}