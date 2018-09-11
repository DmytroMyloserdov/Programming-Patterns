using System;

namespace Patterns.BehaviorPatterns.State
{
    internal class LiquidState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Freezing liquid to solid");
            water.State = new SolidState();
            Console.ResetColor();
        }

        public void Heat(Water water)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Boiling liquid to gas");
            water.State = new GasState();
            Console.ResetColor();
        }
    }
}
