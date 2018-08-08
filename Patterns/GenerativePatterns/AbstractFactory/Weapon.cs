namespace Patterns.GenerativePatterns.AbstractFactory
{
    internal abstract class Weapon
    {
        public double Damage { get; set; }

        public Weapon(double damage)
        {
            Damage = damage;
        }

        public abstract void Hit();
    }
}
