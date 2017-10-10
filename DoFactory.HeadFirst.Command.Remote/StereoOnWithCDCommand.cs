namespace DoFactory.HeadFirst.Command.Remote
{
    public class StereoOnWithCDCommand : ICommand
    {
        private Stereo _stereo;

        #region CONSTRUCTORS

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        #endregion

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }
    }
}