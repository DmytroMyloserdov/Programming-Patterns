namespace Patterns.BehaviorPatterns.Observer
{
    internal interface IObservable
    {
        void AddBetter(IObserver better);
        void RemoveBetter(IObserver better);
        void Play();
    }

    internal enum BetColor
    {
        Red,
        Black,
        Zero
    }
}
