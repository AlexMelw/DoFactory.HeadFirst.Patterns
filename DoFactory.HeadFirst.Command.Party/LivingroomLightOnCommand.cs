namespace DoFactory.HeadFirst.Command.Party
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

        public void Undo()
        {
            _light.Off();
        }
    }
}