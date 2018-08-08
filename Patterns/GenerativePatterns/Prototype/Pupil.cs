using System;

namespace Patterns.GenerativePatterns.Prototype
{
    internal class Pupil : IStudiable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
        public string School { get; set; }

        public Pupil(string firstName, string lastName, string school)
        {
            FirstName = firstName;
            LastName = lastName;
            School = school;
        }

        public IStudiable Clone()
        {
            return new Pupil(FirstName, LastName, School);
        }

        public void GetEducationalInstitution()
        {
            Console.WriteLine($"Pupil { FullName } studies at { School }");
        }
    }
}
