using System;

namespace Patterns.BehaviorPatterns.State
{
    internal class SolidState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Decreasing solid`s temperature");
            Console.ResetColor();
        }

        public void Heat(Water water)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Heating solid to liquid");
            water.State = new LiquidState();
            Console.ResetColor();
        }
    }
}
