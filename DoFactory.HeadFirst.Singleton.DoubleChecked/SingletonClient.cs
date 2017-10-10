namespace DoFactory.HeadFirst.Singleton.DoubleChecked
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

    #endregion
}