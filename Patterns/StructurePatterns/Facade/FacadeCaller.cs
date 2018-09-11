namespace Patterns.StructurePatterns.Facade
{
    public class FacadeCaller
    {
        public static void Call()
        {
            TextEditor textEditor = new TextEditor();
            Compiler compiler = new Compiler();
            CLR clr = new CLR();
            VSFacade vsFacade = new VSFacade(textEditor, compiler, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(vsFacade);
        }
    }
}
