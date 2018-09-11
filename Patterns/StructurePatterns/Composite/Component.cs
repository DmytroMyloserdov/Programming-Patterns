using System;

namespace Patterns.StructurePatterns.Composite
{
    internal abstract class Component
    {
        public bool IsDirectory = false;
        public string Path { get; set; }

        public Component(string path)
        {
            Path = path;
        }

        public virtual void Add(Component component) { }
        public virtual void Remove(Component component) { }

        public virtual void Print()
        {
            Console.WriteLine(Path);
        }
    }
}
