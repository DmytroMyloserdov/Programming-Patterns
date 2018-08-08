namespace Patterns.GenerativePatterns.Singleton
{
    public class SingletonCaller
    {
        public static void Call()
        {
            var instance = Singleton.Current;
            instance = Singleton.Current;
        }
    }
}
