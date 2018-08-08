using System;

namespace Patterns.GenerativePatterns.AbstractFactory
{
    internal class Sword : Weapon
    {
        public Sword(double damage)
            : base(damage)
        {
        }

        public override void Hit()
        {
            Console.WriteLine($"Hit using sword gave { Damage } HP");
        }
    }
}
