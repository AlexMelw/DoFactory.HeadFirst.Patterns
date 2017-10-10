namespace DoFactory.HeadFirst.Command.SimpleRemote
{
    public class GarageDoorOpenCommand : ICommand
    {
        private GarageDoor _garageDoor;

        #region CONSTRUCTORS

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        #endregion

        public void Execute()
        {
            _garageDoor.Up();
        }
    }
}