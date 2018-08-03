namespace Patterns.GenerativePatterns.Factory
{
    public abstract class CompanyCreator
    {
        public abstract Company Create(string name, double productPrice);
    }
}
