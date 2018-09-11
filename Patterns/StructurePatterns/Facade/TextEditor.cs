using System;

namespace Patterns.StructurePatterns.Facade
{
    internal class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("The best code in the world has already been written");
        }

        public void Save()
        {
            Console.WriteLine("The code has been saved");
        }
    }
}
