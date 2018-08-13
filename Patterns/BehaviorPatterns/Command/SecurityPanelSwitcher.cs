namespace Patterns.BehaviorPatterns.Command
{
    internal class SecurityPanelSwitcher : ICommand
    {
        SecurityPanel SPanel;

        public SecurityPanelSwitcher(SecurityPanel sPanel)
        {
            SPanel = sPanel;
        }

        public void Execute()
        {
            SPanel.On();
        }

        public void Undo()
        {
            SPanel.Off();
        }
    }
}
