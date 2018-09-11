using System.Text;

namespace Patterns.BehaviorPatterns.Visitor
{
    internal class XmlVisitor : IVisitor
    {
        public string VisitCompanyAccount(Company account)
        {
            StringBuilder strb = new StringBuilder();
            strb.Append($"<Company><Name>{account.Name}</Name>");
            strb.Append($"<RegNumber>{account.RegNumber}</RegNumber>");
            strb.Append($"<BankAccountNumber>{account.BankAccountNumber}</BankAccountNumber></Company>");

            return strb.ToString();
        }

        public string VisitPersonAccount(Person account)
        {
            StringBuilder strb = new StringBuilder();
            strb.Append($"<Company><Name>{account.Name}</Name>");
            strb.Append($"<BankAccountNumber>{account.BankAccountNumber}</BankAccountNumber></Company>");

            return strb.ToString();
        }
    }
}
