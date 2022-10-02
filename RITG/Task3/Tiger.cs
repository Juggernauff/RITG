using System;

namespace RITG.Task3
{
    internal class Tiger : Predator
    {
        public Tiger(int damage) : base(damage)
        {
            Console.WriteLine("I Tiger!");
        }
        public override void Sound()
        {
            Console.WriteLine("Ррр!");
        }
    }
}
