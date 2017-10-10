namespace DoFactory.HeadFirst.Facade.HomeTheater
{
    using System;

    public class Screen
    {
        private string _description;

        #region CONSTRUCTORS

        public Screen(string description)
        {
            _description = description;
        }

        #endregion

        public void Up()
        {
            Console.WriteLine(_description + " going up");
        }

        public void Down()
        {
            Console.WriteLine(_description + " going down");
        }


        public override string ToString()
        {
            return _description;
        }
    }
}