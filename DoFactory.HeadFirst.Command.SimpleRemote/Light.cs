namespace DoFactory.HeadFirst.Command.SimpleRemote
{
    using System;

    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light is On");
        }

        public void Off()
        {
            Console.WriteLine("Light is Off");
        }
    }
}