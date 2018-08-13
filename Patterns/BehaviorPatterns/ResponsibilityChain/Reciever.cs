namespace Patterns.BehaviorPatterns.ResponsibilityChain
{
    internal class Reciever
    {
        public bool MoneyTransfer { get; set; }
        public bool CardTransfer { get; set; }
        public bool WebTransfer { get; set; }

        public Reciever(bool moneyTr, bool cardTr, bool webTr)
        {
            MoneyTransfer = moneyTr;
            CardTransfer = cardTr;
            WebTransfer = webTr;
        }
    }
}
