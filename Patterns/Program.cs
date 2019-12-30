using Observer;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Observer
            WeatherData weatherData = new WeatherData();
            CurentConditionsDisplay curentConditionsDisplay = new CurentConditionsDisplay(weatherData);

            weatherData.SetMasuremtnts(10, 20, 30);
            weatherData.SetMasuremtnts(34, 34, 45);

            // Strategy
            Strategy.Duck duck = new Strategy.MallardDuck();
            duck.PerfomFly();
            duck.PerfomQuack();
            duck.FlyBehavior = new Strategy.FlyRocketPowered();
            duck.QuackBehavior = new Strategy.MuteQuack();
            duck.PerfomFly();
            duck.PerfomQuack();
        }
    }
}
