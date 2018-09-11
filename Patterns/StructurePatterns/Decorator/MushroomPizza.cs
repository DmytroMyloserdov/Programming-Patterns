namespace Patterns.StructurePatterns.Decorator
{
    internal class MushroomPizza : PizzaDecorator
    {
        public MushroomPizza(Pizza basePizza)
            : base($"{basePizza.Title} with mushrooms", basePizza)
        {
        }

        public override int GetCost()
        {
            return _basePizza.GetCost() + 3;
        }
    }
}
