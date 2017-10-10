namespace DoFactory.HeadFirst.Observer.WeatherStationObservable
{
    public class WeatherData : Observable
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public float Temperature
        {
            get { return _temperature; }
        }

        public float Humidity
        {
            get { return _humidity; }
        }

        public float Pressure
        {
            get { return _pressure; }
        }

        public void MeasurementsChanged()
        {
            Changed = true;
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}