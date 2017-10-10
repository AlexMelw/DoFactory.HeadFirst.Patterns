namespace DoFactory.HeadFirst.Singleton.Classic
{
    using System;

    public class Singleton
    {
        private static Singleton _uniqueInstance;

        #region CONSTRUCTORS

        // other useful instance variables here

        // * Private* Constructor
        private Singleton() { }

        #endregion

        public static Singleton getInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new Singleton();
            }
            return _uniqueInstance;
        }

        public void SaySomething()
        {
            Console.WriteLine("Hi, here I am");
        }

        // other useful methods here
    }
}