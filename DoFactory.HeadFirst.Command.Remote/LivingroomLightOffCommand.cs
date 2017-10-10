namespace DoFactory.HeadFirst.Command.Remote
{
    public class LivingroomLightOffCommand : ICommand
    {
        private Light _light;

        #region CONSTRUCTORS

        public LivingroomLightOffCommand(Light light)
        {
            _light = light;
        }

        #endregion

        public void Execute()
        {
            _light.Off();
        }
    }
}