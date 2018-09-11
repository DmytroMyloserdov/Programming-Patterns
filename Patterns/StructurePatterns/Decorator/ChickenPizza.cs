namespace Patterns.StructurePatterns.Decorator
{
    internal class ChickenPizza : PizzaDecorator
    {
        public ChickenPizza(Pizza basePizza)
            : base($"{basePizza.Title} with chicken", basePizza)
        {
        }

        public override int GetCost()
        {
            return _basePizza.GetCost() + 8;
        }
    }
}
