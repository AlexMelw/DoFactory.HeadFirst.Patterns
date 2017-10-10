namespace DoFactory.HeadFirst.Observer.WeatherStationObservable
{
    using System;

    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float _maxTemp = 0.0f;
        private float _minTemp = 200;
        private float _tempSum = 0.0f;
        private int _numReadings;

        #region CONSTRUCTORS

        public StatisticsDisplay(Observable observable)
        {
            observable.AddObserver(this);
        }

        #endregion

        public void Update(object subject)
        {
            if (subject is WeatherData)
            {
                WeatherData weatherData = (WeatherData) subject;
                float temp = weatherData.Temperature;
                _tempSum += temp;
                _numReadings++;

                if (temp > _maxTemp)
                {
                    _maxTemp = temp;
                }

                if (temp < _minTemp)
                {
                    _minTemp = temp;
                }

                Display();
            }
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + _tempSum / _numReadings
                              + "/" + _maxTemp + "/" + _minTemp);
        }
    }
}