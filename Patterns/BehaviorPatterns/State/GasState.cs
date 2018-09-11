using System;

namespace Patterns.BehaviorPatterns.State
{
    internal class GasState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Freezing gas to liquid");
            water.State = new LiquidState();
            Console.ResetColor();
        }

        public void Heat(Water water)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Increasing temperature of gas");
            Console.ResetColor();
        }
    }
}
