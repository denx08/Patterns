using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
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
