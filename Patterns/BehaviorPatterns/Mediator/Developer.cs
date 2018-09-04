using System;

namespace Patterns.BehaviorPatterns.Mediator
{
    internal class Developer : Worker
    {
        public Developer(IMediator mediator)
            : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to developer: { message }");
        }

        public override void Send(string message)
        {
            _mediator.Send(message, this);
        }
    }
}
