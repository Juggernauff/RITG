using System;

namespace RITG.Task3
{
    internal abstract class Predator : Animal
    {
        public Predator(int damage) : base()
        {
            Damage = damage;
            Console.WriteLine("I Predator!");
        }
        public void Attack()
        {
            Console.WriteLine($"{GetType().Name} attacks with {Damage} damage!");
        }
        private int Damage { get; }
    }
}
