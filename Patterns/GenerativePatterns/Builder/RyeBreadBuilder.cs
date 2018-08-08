namespace Patterns.GenerativePatterns.Builder
{
    internal class RyeBreadBuilder : BreadBuilder
    {
        public override void AddAdditionals()
        {
        }

        public override void AddFlour()
        {
            Bread.Flour = "Rye";
        }

        public override void AddYeast()
        {
            Bread.Yeast = true;
        }
    }
}
