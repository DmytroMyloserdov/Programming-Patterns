namespace Patterns.StructurePatterns.Decorator
{
    internal abstract class Pizza
    {
        public string Title { get; set; }

        public Pizza(string title)
        {
            Title = title;
        }

        public abstract int GetCost();

        public override string ToString()
        {
            return $"Title: {Title}, Cost: {GetCost()}";
        }
    }
}
