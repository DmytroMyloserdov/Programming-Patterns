using System;

namespace Patterns.StructurePatterns.Facade
{
    internal class CLR
    {
        public void Execute()
        {
            Console.WriteLine("The app has been started");
        }

        public void Finish()
        {
            Console.WriteLine("The app has been stoped");
        }
    }
}
