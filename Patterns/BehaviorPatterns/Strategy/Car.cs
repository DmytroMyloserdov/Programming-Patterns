namespace Patterns.BehaviorPatterns.Strategy
{
    internal class Car
    {
        public IMovable Movable { private get; set; }

        public Car(IMovable movable)
        {
            Movable = movable;
        }

        public void Move()
        {
            Movable.Move();
        }
    }
}
