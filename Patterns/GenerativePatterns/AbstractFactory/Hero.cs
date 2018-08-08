namespace Patterns.GenerativePatterns.AbstractFactory
{
    internal class Hero
    {
        Weapon weapon;
        Movement movement;

        public Hero(HeroFactory heroFactory, double damage, double speed)
        {
            weapon = heroFactory.CreateWeapon(damage);
            movement = heroFactory.CreateMovement(speed);
            heroFactory.Create();
        }

        public void Move()
        {
            movement.Move();
        }

        public void Hit()
        {
            weapon.Hit();
        }
    }
}
