namespace DoFactory.HeadFirst.Command.SimpleRemote
{
    using System;

    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage door is Open");
        }

        public void Down()
        {
            Console.WriteLine("Garage door is Closed");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door is Stopped");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage light is on");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage light is off");
        }
    }
}