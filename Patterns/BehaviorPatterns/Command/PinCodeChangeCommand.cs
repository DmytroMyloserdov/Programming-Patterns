using System;

namespace Patterns.BehaviorPatterns.Command
{
    internal class PinCodeChangeCommand : ICommand
    {
        PinCode PinCode;

        public PinCodeChangeCommand(PinCode pinCode)
        {
            PinCode = pinCode;
        }

        public void Execute()
        {
            PinCode.Change();
        }

        public void Undo()
        {
            Console.WriteLine("You can`t undo pin-code changing");
        }
    }
}
