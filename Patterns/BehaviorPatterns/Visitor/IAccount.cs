namespace Patterns.BehaviorPatterns.Visitor
{
    internal interface IAccount
    {
        string Name { get; set; }
        string BankAccountNumber { get; set; }
        string Accept(IVisitor visitor);
    }
}
