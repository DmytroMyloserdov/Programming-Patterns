namespace Patterns.StructurePatterns.Facade
{
    internal class VSFacade
    {
        TextEditor _textEditor;
        Compiler _compiler;
        CLR _clr;

        public VSFacade(TextEditor textEditor, Compiler compiler, CLR clr)
        {
            _textEditor = textEditor;
            _compiler = compiler;
            _clr = clr;
        }

        public void Start()
        {
            _textEditor.CreateCode();
            _textEditor.Save();
            _compiler.Compile();
            _clr.Execute();
        }

        public void Finish()
        {
            _clr.Finish();
        }
    }
}
