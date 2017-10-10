namespace DoFactory.HeadFirst.Singleton.DoubleChecked
{
    using System;

    public class Singleton
    {
        private static volatile Singleton _uniqueInstance;
        private static readonly object _syncLock = new object();

        #region CONSTRUCTORS

        private Singleton() { }

        #endregion

        public static Singleton getInstance()
        {
            if (_uniqueInstance == null)
            {
                // Lock area where instance is created
                lock (_syncLock)
                {
                    if (_uniqueInstance == null)
                    {
                        _uniqueInstance = new Singleton();
                    }
                }
            }
            return _uniqueInstance;
        }

        public void SaySomething()
        {
            Console.WriteLine("I am double checked, therefore I am");
        }
    }
}