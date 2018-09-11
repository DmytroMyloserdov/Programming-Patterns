using System;

namespace Patterns.BehaviorPatterns.Template
{
    internal class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Go in the first form");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Get school certificate");
        }

        public override void PassExams()
        {
            Console.WriteLine("Pass final exams");
        }

        public override void Study()
        {
            Console.WriteLine("Attend lessons and do homework");
        }
    }
}
