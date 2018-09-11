using System.Text;

namespace Patterns.BehaviorPatterns.Visitor
{
    internal class HtmlVisitor : IVisitor
    {
        public string VisitCompanyAccount(Company account)
        {
            StringBuilder strb = new StringBuilder();
            strb.Append($"<tr><td>Name</td><td>{account.Name}</td></tr>");
            strb.Append($"<tr><td>RegNumber</td><td>{account.RegNumber}</td></tr>");
            strb.Append($"<tr><td>BankAccountNumber</td><td>{account.BankAccountNumber}</td></tr>");

            return strb.ToString();
        }

        public string VisitPersonAccount(Person account)
        {
            StringBuilder strb = new StringBuilder();
            strb.Append($"<tr><td>Name</td><td>{account.Name}</td></tr>");
            strb.Append($"<tr><td>BankAccountNumber</td><td>{account.BankAccountNumber}</td></tr>");

            return strb.ToString();
        }
    }
}
