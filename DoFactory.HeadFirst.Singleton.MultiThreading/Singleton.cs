namespace DoFactory.HeadFirst.Singleton.MultiThreading
{
    using System;

    public class Singleton
    {
        private static Singleton _uniqueInstance;
        private static readonly object _syncLock = new object();

        #region CONSTRUCTORS

        // other useful instance variables here

        private Singleton() { }

        #endregion

        public static Singleton getInstance()
        {
            // Lock entire body of method
            lock (_syncLock)
            {
                if (_uniqueInstance == null)
                {
                    _uniqueInstance = new Singleton();
                }
                return _uniqueInstance;
            }
        }

        // other useful methods here
        public void SaySomething()
        {
            Console.WriteLine("I run, therefore I am");
        }
    }
}