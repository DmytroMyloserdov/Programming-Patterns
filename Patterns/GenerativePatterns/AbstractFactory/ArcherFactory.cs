using System;

namespace Patterns.GenerativePatterns.AbstractFactory
{
    internal class ArcherFactory : HeroFactory
    {
        public override void Create()
        {
            Console.WriteLine("Archer created");
        }

        public override Movement CreateMovement(double speed)
        {
            return new FootMove(speed);
        }

        public override Weapon CreateWeapon(double damage)
        {
            return new Bow(damage);
        }
    }
}
