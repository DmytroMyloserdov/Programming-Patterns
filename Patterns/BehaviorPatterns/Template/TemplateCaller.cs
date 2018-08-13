namespace Patterns.BehaviorPatterns.Template
{
    public class TemplateCaller
    {
        public static void Call()
        {
            Education education = new School();
            education.GetEducation();

            education = new University();
            education.GetEducation();
        }
    }
}
