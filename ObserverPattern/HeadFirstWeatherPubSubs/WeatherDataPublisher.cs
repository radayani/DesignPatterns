using System;
using System.Collections.Generic;

namespace HeadFirstPubSubs
{


    public class WeatherDataPublisher : ISubject
    {

        List<IObserver> observers;
        float temp;
        float humidity;
        float pressure;
        internal WeatherDataPublisher()
        {
          observers = new List<IObserver>();
        }

        public void measurementsChanged()
        {
          notifyObservers();
        }

        public void setMeasurements(float temp, float humidity, float pressure)
        {
          this.temp = temp;
          this.humidity = humidity;
          this.pressure = pressure;
          measurementsChanged();
        }
        

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            for(int i=0;i<observers.Count;i++)
            {
              IObserver observer = observers[i];
              observer.update(temp,humidity,pressure);
            }
        }
    }
}