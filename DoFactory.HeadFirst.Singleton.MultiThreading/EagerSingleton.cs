namespace DoFactory.HeadFirst.Singleton.MultiThreading
{
    sealed class EagerSingleton
    {
        // CLR eagerly initializes static member when class is first used
        // CLR guarantees thread safety for static initialisation
        private static readonly EagerSingleton _instance = new EagerSingleton();

        #region CONSTRUCTORS

        // Note: constructor is private
        private EagerSingleton() { }

        #endregion

        public static EagerSingleton GetInstance()
        {
            return _instance;
        }
    }
}