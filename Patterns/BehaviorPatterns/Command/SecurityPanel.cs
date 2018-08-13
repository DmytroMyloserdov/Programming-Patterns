using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Patterns.BehaviorPatterns.Command
{
    internal class SecurityPanel
    {
        bool TurnedOn;
        public PinCode PinCode { get; private set; } = new PinCode();

        public void On()
        {
            TurnedOn = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Security system is turned on");
            Console.ResetColor();
        }

        public void Off()
        {
            try
            {
                if (PinCode.CheckPinCode())
                {
                    TurnedOn = false;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Security system is turned off");
                    Console.ResetColor();
                }
            }
            catch(OutOfPinCodeAttemptsException)
            {
                Console.WriteLine("You wasted all attempts...");
                AlarmOn();
            }
        }

        private void AlarmOn()
        {
            (new Thread(() =>
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.ResetColor();
                Thread.Sleep(500);
            })).Start();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ALARM!");
                Thread.Sleep(250);
            }
        }
    }
}
