namespace DoFactory.HeadFirst.Command.Undo
{
    public class CeilingFanLowCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private CeilingFanSpeed _previousSpeed;

        #region CONSTRUCTORS

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        #endregion

        public void Execute()
        {
            _previousSpeed = _ceilingFan.Speed;
            _ceilingFan.Low();
        }

        public void Undo()
        {
            switch (_previousSpeed)
            {
                case CeilingFanSpeed.High:
                    _ceilingFan.High();
                    break;
                case CeilingFanSpeed.Medium:
                    _ceilingFan.Medium();
                    break;
                case CeilingFanSpeed.Low:
                    _ceilingFan.Low();
                    break;
                case CeilingFanSpeed.Off:
                    _ceilingFan.Off();
                    break;
            }
        }
    }
}