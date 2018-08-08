using System;

namespace Patterns.GenerativePatterns.Singleton
{
    internal class Singleton
    {
        private static Singleton instance;
        public static Singleton Current
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                    Console.WriteLine("Created 1 time");
                }
                Console.WriteLine("Returned");
                return instance;
            }
        }

        private Singleton()
        {
        }
    }
}
