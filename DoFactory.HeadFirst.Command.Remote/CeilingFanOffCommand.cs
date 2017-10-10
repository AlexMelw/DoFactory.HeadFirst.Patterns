namespace DoFactory.HeadFirst.Command.Remote
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan _ceilingFan;

        #region CONSTRUCTORS

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        #endregion

        public void Execute()
        {
            _ceilingFan.Off();
        }
    }
}