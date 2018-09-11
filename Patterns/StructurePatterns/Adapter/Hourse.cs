using System;

namespace Patterns.StructurePatterns.Adapter
{
    internal class Hourse : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("The traveler is using hourse. The hourse gallops across the field");
        }
    }
}
