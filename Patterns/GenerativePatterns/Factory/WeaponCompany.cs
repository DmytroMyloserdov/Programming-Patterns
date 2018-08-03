using System;

namespace Patterns.GenerativePatterns.Factory
{
    internal class WeaponCompany : Company
    {
        public WeaponCompany(string name, double productPrice) : base(name, productPrice)
        {
            Console.WriteLine("Weapon company created");
        }

        public override void CreateProduct()
        {
            CreatedCount++;
            Console.WriteLine($"Weapon created. Created count { CreatedCount }");
        }

        public override void SellProduct()
        {
            SoldCount++;
            Console.WriteLine($"Weapon sold. Sold count { SoldCount }");
        }
    }
}
