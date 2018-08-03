namespace Patterns.GenerativePatterns.Factory
{
    internal abstract class CompanyCreator
    {
        public abstract Company Create(string name, double productPrice);
    }
}
