using System;

namespace Patterns.BehaviorPatterns.Strategy
{
    internal class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Electric engeene");
        }
    }
}
