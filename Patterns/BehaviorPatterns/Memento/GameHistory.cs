using System.Collections.Generic;

namespace Patterns.BehaviorPatterns.Memento
{
    internal class GameHistory
    {
        public Stack<HeroMemento> History { get; private set; }

        public GameHistory()
        {
            History = new Stack<HeroMemento>();
        }
    }
}
