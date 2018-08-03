namespace Patterns.GenerativePatterns.Factory
{
    internal class ToyCompanyCreator : CompanyCreator
    {
        public override Company Create(string name, double productPrice)
        {
            return new ToyCompany(name, productPrice);
        }
    }
}
