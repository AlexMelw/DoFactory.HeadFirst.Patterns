namespace DoFactory.HeadFirst.Command.Party
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

        public void Undo()
        {
            _light.Off();
        }
    }
}