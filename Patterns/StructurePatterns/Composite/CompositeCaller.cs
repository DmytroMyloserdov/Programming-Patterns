namespace Patterns.StructurePatterns.Composite
{
    public class CompositeCaller
    {
        public static void Call()
        {
            Component fileSystem = new Directory("This PC");
            Component diskD = new Directory("D:");
            Component pngFile = new File("12345.png");
            Component projects = new Directory("Projects");
            Component taskFile = new File("Task.txt");

            fileSystem.Add(diskD);
            diskD.Add(projects);
            projects.Add(taskFile);
            diskD.Add(pngFile);

            fileSystem.Print();
        }
    }
}
