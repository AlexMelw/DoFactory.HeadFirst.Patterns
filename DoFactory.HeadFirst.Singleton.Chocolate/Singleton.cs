namespace DoFactory.HeadFirst.Singleton.Chocolate
{
    public class Singleton
    {
        private static Singleton _uniqueInstance;

        private static readonly object _syncLock = new object();

        #region CONSTRUCTORS

        // other useful instance variables here

        // Constructor
        private Singleton() { }

        #endregion

        public static Singleton GetInstance()
        {
            // Double checked locking
            if (_uniqueInstance == null)
            {
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

        // other useful methods here
    }
}