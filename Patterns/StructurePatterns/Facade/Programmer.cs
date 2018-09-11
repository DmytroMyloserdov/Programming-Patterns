using System;

namespace Patterns.StructurePatterns.Facade
{
    internal class Programmer
    {
        public void CreateApplication(VSFacade vsFacade)
        {
            vsFacade.Start();
            Console.WriteLine("Testing.....");
            vsFacade.Finish();
        }
    }
}
