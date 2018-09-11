using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StructurePatterns.Composite
{
    internal class Directory : Component
    {
        List<Component> _components;

        public Directory(string path)
            : base(path)
        {
            _components = new List<Component>();
        }

        public override void Add(Component component)
        {
            component.Path = $@"{Path}/{component.Path}";
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine(Path);
            _components.ForEach(c => 
            {
                c.Print();
            });
        }
    }
}
