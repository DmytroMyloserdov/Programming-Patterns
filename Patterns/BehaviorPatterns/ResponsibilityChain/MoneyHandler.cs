using System;

namespace Patterns.BehaviorPatterns.ResponsibilityChain
{
    internal class MoneyHandler : ITransferHandler
    {
        public ITransferHandler Next { get; set; }

        public void Handle(Reciever reciever)
        {
            if (reciever.MoneyTransfer)
            {
                Console.WriteLine("Done money transfer");
            }
            else
            {
                Next?.Handle(reciever);
            }
        }
    }
}
