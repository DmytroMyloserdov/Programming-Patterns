using System;

namespace Patterns.BehaviorPatterns.ResponsibilityChain
{
    internal class WebHandler : ITransferHandler
    {
        public ITransferHandler Next { get; set; }

        public void Handle(Reciever reciever)
        {
            if (reciever.WebTransfer)
            {
                Console.WriteLine("Done web transfer");
            }
            else
            {
                Next?.Handle(reciever);
            }
        }
    }
}
