using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm real Mallard duck");
        }
    }
}
