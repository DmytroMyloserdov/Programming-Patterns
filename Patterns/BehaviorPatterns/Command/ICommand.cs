namespace Patterns.BehaviorPatterns.Command
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }

    internal enum Commands
    {
        SecurityOn,
        ChangePinCode,
        Undo
    }
}
