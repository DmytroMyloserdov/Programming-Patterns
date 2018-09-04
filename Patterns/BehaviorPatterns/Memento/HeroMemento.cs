namespace Patterns.BehaviorPatterns.Memento
{
    internal class HeroMemento
    {
        public int Energy { get; set; }
        public int HP { get; set; }

        public HeroMemento(int energy, int hp)
        {
            HP = hp;
            Energy = energy;
        }
    }
}
