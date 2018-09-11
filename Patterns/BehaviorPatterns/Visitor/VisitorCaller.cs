using System;
using System.Linq;

namespace Patterns.BehaviorPatterns.Visitor
{
    public class VisitorCaller
    {
        public static void Call()
        {
            var bank = new Bank();

            bank.AddAccount(new Person() { Name = "John Smith", BankAccountNumber = "123456789" });
            bank.AddAccount(new Company() { Name = "Google", RegNumber = "555446", BankAccountNumber = "987654321" });

            Console.WriteLine("HTML view");
            bank.AcceptAll(new HtmlVisitor()).ToList().ForEach(acc => Console.WriteLine(acc));
            Console.WriteLine("\nXML view");
            bank.AcceptAll(new XmlVisitor()).ToList().ForEach(acc => Console.WriteLine(acc));
        }
    }
}
