using System;

namespace HeadFirstPubSubs
{
    public class SubscriberStaticsDisplay : IObserver, IDisplayElement
    {
        float pressure; 
        ISubject weatherData;

        public SubscriberStaticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Statistics display " + pressure);
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.pressure = pressure;
            display();
        }
    }
}