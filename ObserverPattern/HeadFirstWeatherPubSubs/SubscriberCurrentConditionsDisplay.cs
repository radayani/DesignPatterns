using System;

namespace HeadFirstPubSubs
{
    public class SubscriberCurrentConditionsDisplay : IObserver, IDisplayElement
    {
        float temp; 
        float humidity;
        ISubject weatherData;

        public SubscriberCurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Current conditions display " + temp + " humidity " + humidity);
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            display();
        }
    }
}