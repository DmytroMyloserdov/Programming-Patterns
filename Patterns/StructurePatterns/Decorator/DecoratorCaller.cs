using System;

namespace Patterns.StructurePatterns.Decorator
{
    public class DecoratorCaller
    {
        public static void Call()
        {
            Pizza italian = new ItalianPizza();
            Console.WriteLine(italian.ToString());

            italian = new MushroomPizza(italian);
            Console.WriteLine(italian.ToString());

            italian = new ChickenPizza(italian);
            Console.WriteLine(italian.ToString());
        }
    }
}
