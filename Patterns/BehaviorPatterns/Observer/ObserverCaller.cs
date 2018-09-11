using System;

namespace Patterns.BehaviorPatterns.Observer
{
    public class ObserverCaller
    {
        public static void Call()
        {
            var playerJohn = new Better("John", 500);
            var playerAlex = new Better("Alex", 500);
            var playerKate = new Better("Kate", 500);

            IObservable bet = new Bet();
            
            playerAlex.MakeOrChangeBet(ref bet, BetColor.Black, 100);
            playerJohn.MakeOrChangeBet(ref bet, BetColor.Red, 100);
            playerKate.MakeOrChangeBet(ref bet, BetColor.Zero, 100);

            Console.WriteLine();
            bet.Play();
        }
    }
}
