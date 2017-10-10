namespace DoFactory.HeadFirst.Observer.WeatherStationObservable
{
    using System;

    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private Observable _observable;
        private float _temperature;
        private float _humidity;

        #region CONSTRUCTORS

        public CurrentConditionsDisplay(Observable observable)
        {
            _observable = observable;
            observable.AddObserver(this);
        }

        #endregion

        public void Update(object subject)
        {
            if (subject is WeatherData)
            {
                WeatherData weatherData = (WeatherData) subject;
                _temperature = weatherData.Temperature;
                _humidity = weatherData.Humidity;
                Display();
            }
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature
                              + "F degrees and " + _humidity + "% humidity");
        }
    }
}