namespace DoFactory.HeadFirst.Facade.HomeTheater
{
    using System;

    public class TheaterLights
    {
        private string _description;

        #region CONSTRUCTORS

        public TheaterLights(string description)
        {
            _description = description;
        }

        #endregion

        public void On()
        {
            Console.WriteLine(_description + " on");
        }

        public void Off()
        {
            Console.WriteLine(_description + " off");
        }

        public void Dim(int level)
        {
            Console.WriteLine(_description + " dimming to " + level + "%");
        }

        public override string ToString()
        {
            return _description;
        }
    }
}