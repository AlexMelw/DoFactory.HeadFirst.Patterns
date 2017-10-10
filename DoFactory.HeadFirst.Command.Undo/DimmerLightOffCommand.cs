namespace DoFactory.HeadFirst.Command.Undo
{
    public class DimmerLightOffCommand : ICommand
    {
        private Light _light;
        private int _previousLevel = 100;

        #region CONSTRUCTORS

        public DimmerLightOffCommand(Light light)
        {
            _light = light;
        }

        #endregion

        public void Execute()
        {
            _previousLevel = _light.Level;
            _light.Off();
        }

        public void Undo()
        {
            _light.Dim(_previousLevel);
        }
    }
}