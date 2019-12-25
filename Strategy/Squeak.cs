using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeck");
        }
    }
}
