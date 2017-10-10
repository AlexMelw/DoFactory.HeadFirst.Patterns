namespace DoFactory.HeadFirst.Singleton.Chocolate
{
    using System;

    class ChocolateController
    {
        static void Main(string[] args)
        {
            var boiler = ChocolateBoiler.GetInstance();
            boiler.Fill();
            boiler.Boil();
            boiler.Drain();

            // will return the existing instance
            var boiler2 = ChocolateBoiler.GetInstance();

            // Are they the same?
            if (boiler == boiler2)
            {
                Console.WriteLine("Same instances");
            }

            var s1 = Singleton.GetInstance();
            var s2 = Singleton.GetInstance();
            var s3 = Singleton.GetInstance();

            if (s1 == s2 && s2 == s3)
            {
                Console.WriteLine("Same instances");
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    #region ChocolateBoiler

    #endregion

    #region Singleton

    #endregion
}