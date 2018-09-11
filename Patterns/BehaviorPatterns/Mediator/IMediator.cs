namespace Patterns.BehaviorPatterns.Mediator
{
    internal interface IMediator
    {
        void Send(string message, Worker sender);
    }
}
