namespace DoFactory.HeadFirst.Command.Remote
{
    public class GarageDoorUpCommand : ICommand
    {
        private GarageDoor _garageDoor;

        #region CONSTRUCTORS

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        #endregion

        public void Execute()
        {
            _garageDoor.up();
        }
    }
}