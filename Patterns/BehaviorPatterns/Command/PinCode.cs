using System;
using System.Text;

namespace Patterns.BehaviorPatterns.Command
{
    internal class PinCode
    {
        string Value = "0000";
        private int _attempts = 3;
        public int Attempts
        {
            get
            {
                return _attempts;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new OutOfPinCodeAttemptsException();
                }
                else
                {
                    _attempts = value;
                }
            }
        }

        public void Change()
        {
            if (CheckPinCode())
            { 
                Value = GetPinCode("Enter new pin-code (4 digits): ");
                _attempts = 3;
                Console.WriteLine("Pin-code has successfuly changed");
            }
            else
            {
                return;
            }
        }

        public string GetPinCode(string startMessage)
        {
            Console.Write(startMessage);
            return Console.ReadLine();
        }

        public bool CheckPinCode()
        {
            var code = GetPinCode("Enter pin-code (4 digits): ");
            if (code != Value)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong pin-code. Exiting...");
                Attempts--;
                Console.ResetColor();
                return false;
            }
            return true;
        }
    }

    internal class OutOfPinCodeAttemptsException : Exception
    {
    }
}
