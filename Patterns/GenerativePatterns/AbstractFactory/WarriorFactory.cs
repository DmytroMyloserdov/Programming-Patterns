using System;

namespace Patterns.GenerativePatterns.AbstractFactory
{
    internal class WarriorFactory : HeroFactory
    {
        public override void Create()
        {
            Console.WriteLine("Warrior created");
        }

        public override Movement CreateMovement(double speed)
        {
            return new HourseMove(speed);
        }

        public override Weapon CreateWeapon(double damage)
        {
            return new Sword(damage);
        }
    }
}
