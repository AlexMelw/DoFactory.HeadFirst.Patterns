namespace DoFactory.HeadFirst.Singleton.MultiThreading
{
    using System;

    class SingletonClient
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.getInstance();
            singleton.SaySomething();

            // .NET singleton threadsafe example.

            var es1 = EagerSingleton.GetInstance();
            var es2 = EagerSingleton.GetInstance();
            var es3 = EagerSingleton.GetInstance();

            if (es1 == es2 && es2 == es3)
            {
                Console.WriteLine("Same instance");
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    #region Singleton

    #endregion
}