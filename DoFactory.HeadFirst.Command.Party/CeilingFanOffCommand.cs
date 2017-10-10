namespace DoFactory.HeadFirst.Command.Party
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private CeilingFanSpeed _prevSpeed;

        #region CONSTRUCTORS

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        #endregion

        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.Off();
        }

        public void Undo()
        {
            switch (_prevSpeed)
            {
                case CeilingFanSpeed.High:
                    _ceilingFan.high();
                    break;
                case CeilingFanSpeed.Medium:
                    _ceilingFan.medium();
                    break;
                case CeilingFanSpeed.Low:
                    _ceilingFan.low();
                    break;
                case CeilingFanSpeed.Off:
                    _ceilingFan.Off();
                    break;
            }
        }
    }
}