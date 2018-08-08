namespace Patterns.GenerativePatterns.Builder
{
    internal class WheatBreadBuilder : BreadBuilder
    {
        public override void AddAdditionals()
        {
            Bread.Aditionals.Add("Sesame");
        }

        public override void AddFlour()
        {
            Bread.Flour = "Wheat";
        }

        public override void AddYeast()
        {
        }
    }
}
