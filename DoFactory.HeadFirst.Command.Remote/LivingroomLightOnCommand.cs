namespace DoFactory.HeadFirst.Command.Remote
{
    public class LivingroomLightOnCommand : ICommand
    {
        private Light _light;

        #region CONSTRUCTORS

        public LivingroomLightOnCommand(Light light)
        {
            _light = light;
        }

        #endregion

        public void Execute()
        {
            _light.On();
        }
    }
}