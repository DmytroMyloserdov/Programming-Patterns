namespace Patterns.GenerativePatterns.Factory
{
    public class ToyCompanyCreator : CompanyCreator
    {
        public override Company Create(string name, double productPrice)
        {
            return new ToyCompany(name, productPrice);
        }
    }
}
