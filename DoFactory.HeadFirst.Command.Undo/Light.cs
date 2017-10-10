namespace DoFactory.HeadFirst.Command.Undo
{
    using System;

    public class Light
    {
        private string _location;

        public int Level { get; private set; }

        #region CONSTRUCTORS

        public Light(string location)
        {
            _location = location;
        }

        #endregion

        public void On()
        {
            Level = 100;
            Console.WriteLine("Light is on");
        }

        public void Off()
        {
            Level = 0;
            Console.WriteLine("Light is off");
        }

        public void Dim(int level)
        {
            Level = level;
            if (Level == 0)
            {
                Off();
            }
            else
            {
                Console.WriteLine("Light is dimmed to " + Level + "%");
            }
        }
    }
}