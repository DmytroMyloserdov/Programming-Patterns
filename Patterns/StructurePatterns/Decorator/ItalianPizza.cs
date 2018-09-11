namespace Patterns.StructurePatterns.Decorator
{
    internal class ItalianPizza : Pizza
    {
        public ItalianPizza()
            : base("Italian pizza")
        {
        }

        public override int GetCost()
        {
            return 10;
        }
    }
}
