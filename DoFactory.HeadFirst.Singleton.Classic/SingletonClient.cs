namespace DoFactory.HeadFirst.Singleton.Classic
{
    using System;

    class SingletonClient
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.getInstance();
            singleton.SaySomething();

            // Wait for user
            Console.ReadKey();
        }
    }

    #region Singleton

    // NOTE: This is not thread safe

    #endregion
}