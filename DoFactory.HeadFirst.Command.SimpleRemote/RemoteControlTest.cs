namespace DoFactory.HeadFirst.Command.SimpleRemote
{
    using System;

    class RemoteControlTest
    {
        static void Main(string[] args)
        {
            var remote = new SimpleRemoteControl();

            var light = new Light();
            var lightOn = new LightOnCommand(light);

            var garageDoor = new GarageDoor();
            var garageOpen = new GarageDoorOpenCommand(garageDoor);

            remote.Command = lightOn;
            remote.ButtonWasPressed();

            remote.Command = garageOpen;
            remote.ButtonWasPressed();

            // Wait for user
            Console.ReadKey();
        }
    }

    #region SimpleRemoteControl

    // The invoker

    #endregion

    #region Command

    #endregion

    #region Light, GarageDoor

    #endregion
}