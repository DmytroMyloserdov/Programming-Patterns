namespace Patterns.BehaviorPatterns.Mediator
{
    public class MediatorCaller
    {
        public static void Call()
        {
            NotificationManager mediator = new NotificationManager();

            Worker customer = new Customer(mediator);
            Worker developer = new Developer(mediator);
            Worker qa = new QA(mediator);

            mediator.SetListeners(customer, developer, qa);

            customer.Send("Need new solution");
            developer.Send("Task don need testing");
            qa.Send("No bugs detected, solution is done");
        }
    }
}
