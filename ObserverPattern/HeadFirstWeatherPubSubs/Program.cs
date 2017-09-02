using System;

namespace HeadFirstPubSubs
{
    public class WeatherStationSimulation
    {
        public static void Main(string[] args)
        {
            var weatherDataPub = new WeatherDataPublisher();
            var currentDisplaySub = new SubscriberCurrentConditionsDisplay(weatherDataPub);
            var statsDisplaySub = new SubscriberStaticsDisplay(weatherDataPub);
            weatherDataPub.setMeasurements(10,12,34);
            weatherDataPub.setMeasurements(10,133.3f,34.3f);
            
        }
    }
}
