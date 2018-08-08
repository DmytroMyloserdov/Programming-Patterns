namespace Patterns.GenerativePatterns.AbstractFactory
{
    internal abstract class HeroFactory
    {
        public abstract void Create();
        public abstract Movement CreateMovement(double speed);
        public abstract Weapon CreateWeapon(double damage);
    }
}
