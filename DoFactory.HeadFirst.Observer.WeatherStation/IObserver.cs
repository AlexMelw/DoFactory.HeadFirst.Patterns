namespace DoFactory.HeadFirst.Observer.WeatherStation
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}