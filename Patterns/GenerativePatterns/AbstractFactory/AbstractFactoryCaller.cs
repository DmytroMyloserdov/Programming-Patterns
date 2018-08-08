using System;

namespace Patterns.GenerativePatterns.AbstractFactory
{
    public class AbstractFactoryCaller
    {
        public static void Call()
        {
            HeroFactory factory = new WarriorFactory();
            var warrior = new Hero(factory, 5, 7);
            warrior.Move();
            warrior.Hit();
            Console.WriteLine();

            factory = new ArcherFactory();
            var archer = new Hero(factory, 3, 2);
            archer.Move();
            archer.Hit();
        }
    }
}
