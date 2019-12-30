using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float himidity;
        private float presure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            foreach(var observer in observers)
            {
                observer.Update(temperature, himidity, presure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void measurementChanged()
        {
            NotifyObserver();
        }

        public void SetMasuremtnts(float temperature, float himidity, float presure)
        {
            this.temperature = temperature;
            this.himidity = himidity;
            this.presure = presure;
            measurementChanged();
        }
    }
}
