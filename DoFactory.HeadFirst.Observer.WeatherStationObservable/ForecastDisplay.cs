namespace DoFactory.HeadFirst.Observer.WeatherStationObservable
{
    using System;

    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _currentPressure = 29.92f;
        private float _lastPressure;

        #region CONSTRUCTORS

        public ForecastDisplay(Observable observable)
        {
            observable.AddObserver(this);
        }

        #endregion

        public void Update(object subject)
        {
            if (subject is WeatherData)
            {
                WeatherData weatherData = (WeatherData) subject;
                _lastPressure = _currentPressure;
                _currentPressure = weatherData.Pressure;
                Display();
            }
        }


        public void Display()
        {
            Console.Write("Forecast: ");
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (_currentPressure < _lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }
    }
}