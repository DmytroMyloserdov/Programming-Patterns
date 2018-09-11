namespace Patterns.BehaviorPatterns.Strategy
{
    public class StrategyCaller
    {
        public static void Call()
        {
            IMovable movable = new ElectricMove();
            var car = new Car(movable);
            car.Move();

            movable = new PetrolMove();
            car.Movable = movable;
            car.Move();
        }
    }
}
