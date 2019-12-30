using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class CurentConditionsDisplay : IObserver, IDisplayElement
    {
        float temperature;
        float humidity;
        ISubject weatherData;

        public CurentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
        }

        public void Update(float temperature, float himidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = himidity;
            Display();
        }
    }
}
