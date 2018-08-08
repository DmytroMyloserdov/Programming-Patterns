using System;

namespace Patterns.GenerativePatterns.AbstractFactory
{
    internal class Bow : Weapon
    {
        public Bow(double damage)
            : base(damage)
        {
        }

        public override void Hit()
        {
            Console.WriteLine($"Hit using bow gave { Damage } HP");
        }
    }
}
