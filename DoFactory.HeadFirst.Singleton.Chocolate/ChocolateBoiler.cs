namespace DoFactory.HeadFirst.Singleton.Chocolate
{
    using System;

    public class ChocolateBoiler
    {
        private static ChocolateBoiler _uniqueInstance;

        private bool _empty;
        private bool _boiled;

        // Properties 
        public bool Empty
        {
            get { return _empty; }
        }

        public bool Boiled
        {
            get { return _boiled; }
        }

        #region CONSTRUCTORS

        // *Private* constructor
        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        #endregion

        public static ChocolateBoiler GetInstance()
        {
            if (_uniqueInstance == null)
            {
                Console.WriteLine("Creating unique instance of Chocolate Boiler");
                _uniqueInstance = new ChocolateBoiler();
            }

            Console.WriteLine("Returning instance of Chocolate Boiler");
            return _uniqueInstance;
        }

        public void Fill()
        {
            if (Empty)
            {
                _empty = false;
                _boiled = false;
                // fill the boiler with a milk/chocolate mixture
            }
        }

        public void Drain()
        {
            if (Empty && Boiled)
            {
                // drain the boiled milk and chocolate
                _empty = true;
            }
        }

        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                // bring the contents to a boil
                _boiled = true;
            }
        }
    }
}