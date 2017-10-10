namespace DoFactory.HeadFirst.Command.Undo
{
    public class DimmerLightOnCommand : ICommand
    {
        private Light _light;
        private int _previousLevel;

        #region CONSTRUCTORS

        public DimmerLightOnCommand(Light light)
        {
            _light = light;
        }

        #endregion

        public void Execute()
        {
            _previousLevel = _light.Level;
            _light.Dim(75);
        }

        public void Undo()
        {
            _light.Dim(_previousLevel);
        }
    }
}