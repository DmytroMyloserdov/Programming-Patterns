using System;

namespace Patterns.GenerativePatterns.Prototype
{
    public class PrototypeCaller
    {
        public static void Call()
        {
            IStudiable person = new Pupil("John", "Week", "VTL");
            Console.WriteLine("Original pupil");
            person.GetEducationalInstitution();
            IStudiable clonedPerson = person.Clone();
            Console.WriteLine("Cloned pupil");
            clonedPerson.GetEducationalInstitution();

            person = new Student("Tony", "Stark", "VNTU");
            Console.WriteLine("Original student");
            person.GetEducationalInstitution();
            clonedPerson = person.Clone();
            Console.WriteLine("Cloned student");
            clonedPerson.GetEducationalInstitution();
        }
    }
}
