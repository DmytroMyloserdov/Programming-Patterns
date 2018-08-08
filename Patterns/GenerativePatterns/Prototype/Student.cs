using System;

namespace Patterns.GenerativePatterns.Prototype
{
    internal class Student : IStudiable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string University { get; set; }
        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }

        public Student(string firstName, string lastName, string university)
        {
            FirstName = firstName;
            LastName = lastName;
            University = university;
        }

        public IStudiable Clone()
        {
            return new Student(FirstName, LastName, University);
        }

        public void GetEducationalInstitution()
        {
            Console.WriteLine($"Student { FullName } studies at { University }");
        }
    }
}
