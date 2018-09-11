namespace Patterns.BehaviorPatterns.Memento
{
    public class MementoCaller
    {
        public static void Call()
        {
            Hero hero = new Hero();
            GameHistory game = new GameHistory();

            hero.Kick(true);
            hero.TakeDamage(3);
            game.History.Push(hero.SaveChanges());
            hero.Kick(false);
            hero.TakeDamage(1);
            hero.LoadState(game.History.Pop());
        }
    }
}
