namespace DoFactory.HeadFirst.Command.Party
{
    public class StereoOnCommand : ICommand
    {
        private Stereo _stereo;

        #region CONSTRUCTORS

        public StereoOnCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        #endregion

        public void Execute()
        {
            _stereo.On();
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}