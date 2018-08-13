using System.Collections.Generic;
using System.Linq;

namespace Patterns.BehaviorPatterns.Command
{
    internal class SecuritySystemPult
    {
        Dictionary<Commands, ICommand> Commands;
        Stack<ICommand> CommandHistory;

        public SecuritySystemPult()
        {
            Commands = new Dictionary<Commands, ICommand>();
            CommandHistory = new Stack<ICommand>();
        }

        public void AddCommand(Commands commandCode, ICommand command)
        {
            Commands.Add(commandCode, command);
        }

        public void CallCommand(Commands commandCode)
        {
            if (commandCode == Command.Commands.Undo && CommandHistory.Any())
            {
                var command = CommandHistory.Pop();
                command.Undo();
            }
            else
            {
                Commands[commandCode].Execute();
                CommandHistory.Push(Commands[commandCode]);
            }
        }
    }
}
