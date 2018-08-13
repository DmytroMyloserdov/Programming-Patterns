namespace Patterns.BehaviorPatterns.ResponsibilityChain
{
    internal interface ITransferHandler
    {
        ITransferHandler Next { get; set; }
        void Handle(Reciever reciever);
    }
}
