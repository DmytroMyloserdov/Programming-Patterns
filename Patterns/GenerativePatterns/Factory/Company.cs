namespace Patterns.GenerativePatterns.Factory
{
    public abstract class Company
    {
        public string Name { get; set; }
        public double ProductPrice { get; set; }
        public ulong CreatedCount { get; set; }
        public ulong SoldCount { get; set; }

        public Company(string name, double productPrice)
        {
            Name = name;
            ProductPrice = productPrice;
            SoldCount = 0;
        }

        public abstract void CreateProduct();
        public abstract void SellProduct();
    }
}
