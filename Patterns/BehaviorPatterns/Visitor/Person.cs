namespace Patterns.BehaviorPatterns.Visitor
{
    internal class Person : IAccount
    {
        public string Name { get; set; }
        public string BankAccountNumber { get; set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitPersonAccount(this);
        }
    }
}
