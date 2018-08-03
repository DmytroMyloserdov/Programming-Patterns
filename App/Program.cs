using Patterns.GenerativePatterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        delegate void PatternCaller();
        static PatternCaller[][] patternCallers = new PatternCaller[3][]
        {
            new PatternCaller[]
            {
                new PatternCaller(FactoryCaller.Call),
            },
            new PatternCaller[]
            {

            },
            new PatternCaller[]
            {

            }
        };

        static List<string> TypePatterns = new List<string>()
        {
            "\n\t1.Factory\n\t2.Abstract Factory\n\t3.Singletone\n\t4.Prototype\n\t5.Builder",
            "\n\t1.Strategy\n\t2.Observer\n\t3.Command\n\t4.Template\n\t5.Iterator\n\t6.State\n\t7.Responsibility Chain\n\t8.Interpreter\n\t9.Mediator\n\t10.Memento\n\t11.Visitor",
            "\n\t1.Decorator\n\t2.Adapter\n\t3.Facade\n\t4.Composite\n\t5.Proxy\n\t6.Bridge\n\t7.Flyweigth"
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose pattern`s type:\n\t1.Generative Patterns\n\t2.Behavior Patterns\n\t3.Struct Patterns");
                Byte.TryParse(Console.ReadLine(), out byte type);

                Console.WriteLine($"Choose patter:{ TypePatterns[type] }");
                Byte.TryParse(Console.ReadLine(), out byte pattern);

                patternCallers[type][pattern].Invoke();
                Console.Clear();
            }
        }
    }
}
