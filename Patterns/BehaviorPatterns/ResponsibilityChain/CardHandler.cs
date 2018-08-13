using System;

namespace Patterns.BehaviorPatterns.ResponsibilityChain
{
    internal class CardHandler : ITransferHandler
    {
        public ITransferHandler Next { get; set; }

        public void Handle(Reciever reciever)
        {
            if (reciever.CardTransfer)
            {
                Console.WriteLine("Done card transfer");
            }
            else
            {
                Next?.Handle(reciever);
            }
        }
    }
}
