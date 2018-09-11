using System;
using System.Collections.Generic;

namespace Patterns.BehaviorPatterns.Observer
{
    internal class Bet : IObservable
    {
        public BetColor BetResult { get; private set; }
        public List<IObserver> Observers { get; private set; }
        List<int> BlackNumbers = new List<int>() { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        List<int> RedNumbers = new List<int>() { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

        public Bet()
        {
            Observers = new List<IObserver>();
        }

        public void AddBetter(IObserver better)
        {
            Observers.Add(better);
        }

        public void Play()
        {
            var rndResult = (new Random()).Next(0, 37);
            if (rndResult == 0)
            {
                BetResult = BetColor.Zero;
            }
            else if (BlackNumbers.Contains(rndResult))
            {
                BetResult = BetColor.Black;
            }
            else
            {
                BetResult = BetColor.Red;
            }

            foreach (var observer in Observers)
            {
                observer.GetBetResult(BetResult);
            }

            Observers.Clear();
        }

        public void RemoveBetter(IObserver better)
        {
            Observers.Remove(better);
        }
    }
}
