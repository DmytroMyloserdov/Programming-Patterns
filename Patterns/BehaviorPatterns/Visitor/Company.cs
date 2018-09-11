namespace Patterns.BehaviorPatterns.Visitor
{
    internal class Company : IAccount
    {
        public string Name { get; set; }
        public string BankAccountNumber { get; set; }
        public string RegNumber { get; set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitCompanyAccount(this);
        }
    }
}
