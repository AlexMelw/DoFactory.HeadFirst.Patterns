namespace DoFactory.HeadFirst.Command.Party
{
    public class StereoOffCommand : ICommand
    {
        private Stereo _stereo;

        #region CONSTRUCTORS

        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        #endregion

        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
        }
    }
}