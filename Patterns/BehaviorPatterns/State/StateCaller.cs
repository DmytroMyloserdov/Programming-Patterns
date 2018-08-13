namespace Patterns.BehaviorPatterns.State
{
    public class StateCaller
    {
        public static void Call()
        {
            Water water = new Water(new SolidState());
            water.Frost();
            water.Heat();
            water.Heat();
            water.Heat();
            water.Frost();
            water.Frost();
        }
    }
}
