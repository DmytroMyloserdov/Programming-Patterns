using System;

namespace Patterns.BehaviorPatterns.Mediator
{
    internal class QA : Worker
    {
        public QA(IMediator mediator)
            : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to QA: { message }");
        }

        public override void Send(string message)
        {
            _mediator.Send(message, this);
        }
    }
}
