using System;

namespace Patterns.GenerativePatterns.Factory
{
    public class ToyCompany : Company
    {
        public ToyCompany(string name, double productPrice) : base(name, productPrice)
        {
            Console.WriteLine("Toy company created");
        }

        public override void CreateProduct()
        {
            CreatedCount++;
            Console.WriteLine($"Toy created. Created count { CreatedCount }");
        }

        public override void SellProduct()
        {
            SoldCount++;
            Console.WriteLine($"Toy sold. Sold count { SoldCount }");
        }
    }
}
