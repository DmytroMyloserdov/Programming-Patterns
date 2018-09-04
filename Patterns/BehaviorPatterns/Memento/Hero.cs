using System;

namespace Patterns.BehaviorPatterns.Memento
{
    internal class Hero
    {
        int _energy = 10;
        int _hp = 10;
        
        public void Kick(bool isForced)
        {
            Console.WriteLine((isForced ? "Force" : "Ordinary") + " kick done");
            if (isForced)
            {
                _energy -= 3;
            }
            else
            {
                _energy -= 1;
            }
            Console.WriteLine($"{ _energy } energy left");
        }

        public void TakeDamage(int damagePoints)
        {
            _hp -= damagePoints;
            Console.WriteLine($"Hero lost { damagePoints } hp");
        }

        public HeroMemento SaveChanges()
        {
            Console.WriteLine($"Game saved, you have { _hp } hp and { _energy } energy");
            return new HeroMemento(_energy, _hp);
        }

        public void LoadState(HeroMemento memento)
        {
            _energy = memento.Energy;
            _hp = memento.HP;
            Console.WriteLine($"Game loaded, you have { _hp } hp and { _energy } energy");
        }
    }
}
