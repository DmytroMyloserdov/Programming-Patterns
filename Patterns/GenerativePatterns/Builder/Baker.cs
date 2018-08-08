namespace Patterns.GenerativePatterns.Builder
{
    internal class Baker
    {
        public Bread Bake(BreadBuilder breadBuilder)
        {
            breadBuilder.StartBake();
            breadBuilder.AddFlour();
            breadBuilder.AddYeast();
            breadBuilder.AddAdditionals();

            return breadBuilder.Bread;
        }
    }
}
