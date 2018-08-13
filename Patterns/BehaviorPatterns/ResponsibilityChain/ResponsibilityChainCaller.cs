namespace Patterns.BehaviorPatterns.ResponsibilityChain
{
    public class ResponsibilityChainCaller
    {
        public static void Call()
        {
            ITransferHandler money = new MoneyHandler();
            ITransferHandler card = new CardHandler();
            ITransferHandler web = new WebHandler();

            money.Next = card;
            card.Next = web;
            web.Next = money;

            var reciever = new Reciever(true, false, false);
            money.Handle(reciever);

            reciever = new Reciever(false, true, false);
            money.Handle(reciever);

            reciever = new Reciever(false, false, true);
            money.Handle(reciever);
        }
    }
}
