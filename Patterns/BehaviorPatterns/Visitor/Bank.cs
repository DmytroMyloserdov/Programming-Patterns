using System.Collections.Generic;

namespace Patterns.BehaviorPatterns.Visitor
{
    internal class Bank
    {
        List<IAccount> _accounts;

        public Bank()
        {
            _accounts = new List<IAccount>();
        }

        public void AddAccount(IAccount acc) => _accounts.Add(acc);

        public void RemoveAccount(IAccount acc) => _accounts.Remove(acc);

        public IEnumerable<string> AcceptAll(IVisitor visitor)
        {
            foreach (var acc in _accounts)
            {
                yield return acc.Accept(visitor);
            }
        }
    }
}
