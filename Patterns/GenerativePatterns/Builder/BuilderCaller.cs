using System;

namespace Patterns.GenerativePatterns.Builder
{
    public class BuilderCaller
    {
        public static void Call()
        {
            Baker baker = new Baker();
            BreadBuilder breadBuilder = new RyeBreadBuilder();

            Bread ryeBread = baker.Bake(breadBuilder);
            Console.WriteLine(ryeBread.ToString());

            breadBuilder = new WheatBreadBuilder();

            Bread wheatBread = baker.Bake(breadBuilder);
            Console.WriteLine(wheatBread.ToString());
        }
    }
}
