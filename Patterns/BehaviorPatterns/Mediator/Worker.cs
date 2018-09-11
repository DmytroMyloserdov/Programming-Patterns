using System;

namespace Patterns.BehaviorPatterns.Mediator
{
    internal abstract class Worker
    {
        protected IMediator _mediator;

        public Worker(IMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void Send(string message);
        public abstract void Notify(string message);
    }
}
