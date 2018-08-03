namespace Patterns.GenerativePatterns.Factory
{
    internal class WeaponCompanyCreator : CompanyCreator
    {
        public override Company Create(string name, double productPrice)
        {
            return new WeaponCompany(name, productPrice);
        }
    }
}
