namespace DoFactory.HeadFirst.Facade.HomeTheater
{
    using System;

    public class Tuner
    {
        private string _description;
        private Amplifier _amplifier;
        private double _frequency;

        #region CONSTRUCTORS

        public Tuner(string description, Amplifier amplifier)
        {
            _description = description;
            _amplifier = amplifier;
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

        public void SetFrequency(double frequency)
        {
            Console.WriteLine(_description + " setting frequency to " + frequency);
            _frequency = frequency;
        }

        public void SetAm()
        {
            Console.WriteLine(_description + " setting AM mode");
        }

        public void SetFm()
        {
            Console.WriteLine(_description + " setting FM mode");
        }

        public override string ToString()
        {
            return _description;
        }
    }
}