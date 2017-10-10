namespace DoFactory.HeadFirst.Command.SimpleRemote
{
    public class LightOnCommand : ICommand
    {
        private Light _light;

        #region CONSTRUCTORS

        public LightOnCommand(Light light)
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