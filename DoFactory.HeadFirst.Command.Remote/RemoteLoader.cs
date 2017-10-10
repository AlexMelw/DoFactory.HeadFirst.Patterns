namespace DoFactory.HeadFirst.Command.Remote
{
    using System;

    class RemoteLoader
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();

            var livingRoomLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen");
            var ceilingFan = new CeilingFan("Living Room");
            var garageDoor = new GarageDoor("");
            var stereo = new Stereo("Living Room");

            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);
            var kitchenLightOn = new LightOnCommand(kitchenLight);
            var kitchenLightOff = new LightOffCommand(kitchenLight);
            var ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
            var garageDoorUp = new GarageDoorUpCommand(garageDoor);
            var garageDoorDown = new GarageDoorDownCommand(garageDoor);
            var stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remote.SetCommand(3, stereoOnWithCD, stereoOff);

            Console.WriteLine(remote);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);
            remote.OnButtonWasPushed(2);
            remote.OffButtonWasPushed(2);
            remote.OnButtonWasPushed(3);
            remote.OffButtonWasPushed(3);

            // Wait for user
            Console.ReadKey();
        }
    }

    #region RemoteControl

    // This is the invoker

    #endregion

    #region Commands

    #endregion

    #region Light, TV, GarageDoor, CeilingFan, etc

    #endregion
}