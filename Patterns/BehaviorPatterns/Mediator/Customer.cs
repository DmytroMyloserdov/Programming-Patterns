using System;

namespace Patterns.BehaviorPatterns.Mediator
{
    internal class Customer : Worker
    {
        public Customer(IMediator mediator)
            : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to customer: { message }");
        }

        public override void Send(string message)
        {
            _mediator.Send(message, this);
        }
    }
}
