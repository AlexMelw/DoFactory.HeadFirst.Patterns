namespace DoFactory.HeadFirst.Observer.WeatherStation
{
    using System;

    class WeatherStationHeatIndex
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var currentDisplay = new CurrentConditionsDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);
            var heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            // Wait for user
            Console.ReadKey();
        }
    }

    #region Subject

    #endregion

    #region Observer

    #endregion
}