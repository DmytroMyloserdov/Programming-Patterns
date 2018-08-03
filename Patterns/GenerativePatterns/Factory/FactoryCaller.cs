namespace Patterns.GenerativePatterns.Factory
{
    public class FactoryCaller
    {
        public static void Call()
        {
            CompanyCreator companyCreator = new WeaponCompanyCreator();
            var weaponCompany = companyCreator.Create("Military Ware", 10000);
            weaponCompany.CreateProduct();
            weaponCompany.SellProduct();

            companyCreator = new ToyCompanyCreator();
            var toyCompany = companyCreator.Create("Child Fun", 100);
            toyCompany.CreateProduct();
            toyCompany.SellProduct();
        }
    }
}
