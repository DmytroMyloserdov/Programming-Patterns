using System;
using System.Text;

namespace Patterns.BehaviorPatterns.Observer
{
    internal class Better : IObserver
    {
        public bool IsBetMade { get; private set; } = false;
        private BetColor _bet;
        private int bet = 0;

        public int Balance { get; set; }
        public int Bet
        {
            get
            {
                return bet;
            }
            private set
            {
                if (value <= Balance && value >= 0)
                {
                    Balance -= value;
                    bet = value;
                }
                else
                {
                    bet = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid bet`s value, you haven`t got enough money.");
                    Console.ResetColor();
                }
            }
        }
        public string Name { get; set; }

        public Better(string name)
        {
            Name = name;
        }

        public Better(string name, int balance)
            : this(name)
        {
            Balance = balance;
        }

        public void MakeOrChangeBet(ref IObservable bet, BetColor betColor, int betValue)
        {
            if (!IsBetMade)
            {
                _bet = betColor;
                Bet = betValue;
                IsBetMade = true;
            }
            else
            {
                bet.RemoveBetter(this);

                Balance += Bet;
                Bet = betValue;
                _bet = betColor;
            }

            Console.WriteLine($"{ Name } betted");
            bet.AddBetter(this);
        }

        public void CancelBet(ref IObservable bet)
        {
            Balance += Bet;
            Bet = 0;
            bet.RemoveBetter(this);

            Console.WriteLine($"{ Name } canceled bet");
        }

        public void GetBetResult(BetColor res)
        {
            StringBuilder strb = new StringBuilder();
            strb.Append($"{ Name } betted on { _bet } { Bet } tokens and ");
            if (_bet == res)
            {
                if (_bet == BetColor.Red || _bet == BetColor.Black)
                {
                    Balance += Bet * 2;
                    strb.Append($"won { Bet * 2 } tokens");
                    Bet = 0;
                }
            }
            else
            {
                strb.Append($"lost");
                Bet = 0;
            }
            Console.WriteLine(strb.ToString());
        }
    }
}
