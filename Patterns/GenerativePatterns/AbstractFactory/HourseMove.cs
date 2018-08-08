using System;

namespace Patterns.GenerativePatterns.AbstractFactory
{
    internal class HourseMove : Movement
    {
        public HourseMove(double speed)
            : base(speed)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"Hero moved { Speed } meters by hourse");
        }
    }
}
