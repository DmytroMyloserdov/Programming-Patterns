using System;

namespace Patterns.BehaviorPatterns.Strategy
{
    internal class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Petrol engeene");
        }
    }
}
