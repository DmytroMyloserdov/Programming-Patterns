namespace Patterns.BehaviorPatterns.State
{
    internal class Water
    {
        public IWaterState State { get; set; }

        public Water(IWaterState waterState)
        {
            State = waterState;
        }

        public void Heat()
        {
            State.Heat(this);
        }

        public void Frost()
        {
            State.Frost(this);
        }
    }
}
