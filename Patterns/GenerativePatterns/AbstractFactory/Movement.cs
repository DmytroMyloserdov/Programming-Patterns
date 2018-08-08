namespace Patterns.GenerativePatterns.AbstractFactory
{
    internal abstract class Movement
    {
        public double Speed { get; set; }

        public Movement(double speed)
        {
            Speed = speed;
        }

        public abstract void Move();
    }
}
