namespace DoFactory.HeadFirst.Command.Remote
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
    }
}