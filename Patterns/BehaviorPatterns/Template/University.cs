using System;

namespace Patterns.BehaviorPatterns.Template
{
    internal class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Go to university by passing final test`s rate");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Get Bachelor Degree certificate");
        }

        public override void PassExams()
        {
            Console.WriteLine("Pass Bachelor`s tests");
        }

        public override void Study()
        {
            Console.WriteLine("Attend lections");
        }
    }
}
