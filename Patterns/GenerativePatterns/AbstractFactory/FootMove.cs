using System;

namespace Patterns.GenerativePatterns.AbstractFactory
{
    internal class FootMove : Movement
    {
        public FootMove(double speed)
            : base(speed)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"Hero moved { Speed } meters by feet");
        }
    }
}
