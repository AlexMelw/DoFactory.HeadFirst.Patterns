namespace DoFactory.HeadFirst.Command.Party
{
    public class LightOffCommand : ICommand
    {
        private Light _light;

        #region CONSTRUCTORS

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        #endregion

        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}