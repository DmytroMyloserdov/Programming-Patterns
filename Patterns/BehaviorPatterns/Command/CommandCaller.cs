namespace Patterns.BehaviorPatterns.Command
{
    public class CommandCaller
    {
        public static void Call()
        {
            SecurityPanel securityPanel = new SecurityPanel();
            SecuritySystemPult systemPult = new SecuritySystemPult();

            systemPult.AddCommand(Commands.SecurityOn, new SecurityPanelSwitcher(securityPanel));
            systemPult.AddCommand(Commands.ChangePinCode, new PinCodeChangeCommand(securityPanel.PinCode));

            systemPult.CallCommand(Commands.SecurityOn);
            systemPult.CallCommand(Commands.ChangePinCode);
            systemPult.CallCommand(Commands.Undo);
            systemPult.CallCommand(Commands.Undo);
        }
    }
}
