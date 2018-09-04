namespace Patterns.BehaviorPatterns.Mediator
{
    internal class NotificationManager : IMediator
    {
        public Worker Customer { get; private set; }
        public Worker Developer { get; private set; }
        public Worker QA { get; private set; }

        public void SetListeners(Worker customer, Worker developer, Worker qa)
        {
            Customer = customer;
            Developer = developer;
            QA = qa;
        }

        public void Send(string message, Worker sender)
        {
            if (sender == QA)
            {
                Customer.Notify(message);
            }
            else if (sender == Customer)
            {
                Developer.Notify(message);
            }
            else if (sender == Developer)
            {
                QA.Notify(message);
            }
        }
    }
}
