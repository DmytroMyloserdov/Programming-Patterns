namespace Patterns.BehaviorPatterns.State
{
    internal interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}
