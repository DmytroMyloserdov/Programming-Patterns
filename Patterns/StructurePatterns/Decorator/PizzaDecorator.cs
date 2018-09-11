namespace Patterns.StructurePatterns.Decorator
{
    internal abstract class PizzaDecorator : Pizza
    {
        protected Pizza _basePizza;

        public PizzaDecorator(string title, Pizza basePizza)
            : base(title)
        {
            _basePizza = basePizza;
        }
    }
}
