namespace DoFactory.HeadFirst.Command.Remote
{
    public class GarageDoorDownCommand : ICommand
    {
        private GarageDoor _garageDoor;

        #region CONSTRUCTORS

        public GarageDoorDownCommand(GarageDoor garageDoor)
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