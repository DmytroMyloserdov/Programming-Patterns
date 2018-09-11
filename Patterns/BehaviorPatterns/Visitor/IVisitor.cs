namespace Patterns.BehaviorPatterns.Visitor
{
    internal interface IVisitor
    {
        string VisitPersonAccount(Person account);
        string VisitCompanyAccount(Company account);
    }
}
