using System;

namespace Patterns.GenerativePatterns.Prototype
{
    interface IStudiable
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }

        IStudiable Clone();
        void GetEducationalInstitution();
    }
}
