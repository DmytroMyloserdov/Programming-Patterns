using System;

namespace Patterns.StructurePatterns.Adapter
{
    internal class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("The traveler is using car. The car is on the road");
        }
    }
}
