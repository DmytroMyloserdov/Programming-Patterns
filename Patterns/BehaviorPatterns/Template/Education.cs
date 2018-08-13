namespace Patterns.BehaviorPatterns.Template
{
    internal abstract class Education
    {
        public void GetEducation()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }

        public abstract void Enter();
        public abstract void Study();
        public abstract void PassExams();
        public abstract void GetDocument();
    }
}
