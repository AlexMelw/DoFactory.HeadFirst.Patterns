namespace DoFactory.HeadFirst.Command.Undo
{
    using System;

    class RemoteLoader
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControlWithUndo();

            var livingRoomLight = new Light("Living Room");

            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);

            Console.WriteLine(remote);

            remote.UndoButtonWasPushed();
            remote.OffButtonWasPushed(0);
            remote.OnButtonWasPushed(0);

            Console.WriteLine(remote);

            remote.UndoButtonWasPushed();

            var ceilingFan = new CeilingFan("Living Room");

            var ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            var ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            remote.SetCommand(0, ceilingFanMedium, ceilingFanOff);
            remote.SetCommand(1, ceilingFanHigh, ceilingFanOff);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);

            Console.WriteLine(remote);

            remote.UndoButtonWasPushed();
            remote.OnButtonWasPushed(1);

            Console.WriteLine(remote);

            remote.UndoButtonWasPushed();

            // Wait for user
            Console.ReadKey();
        }
    }

    #region Remote Control

    #endregion

    #region Commands

    #endregion

    #region Light and CeilingFan

    #endregion
}