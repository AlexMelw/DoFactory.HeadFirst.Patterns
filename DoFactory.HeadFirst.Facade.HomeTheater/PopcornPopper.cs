namespace DoFactory.HeadFirst.Facade.HomeTheater
{
    using System;

    public class PopcornPopper
    {
        private string _description;

        #region CONSTRUCTORS

        public PopcornPopper(string description)
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

        public void Pop()
        {
            Console.WriteLine(_description + " popping popcorn!");
        }

        public override string ToString()
        {
            return _description;
        }
    }
}