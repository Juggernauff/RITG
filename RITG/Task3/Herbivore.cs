using System;

namespace RITG.Task3
{
    internal abstract class Herbivore : Animal
    {
        public Herbivore() : base()
        {
            Name = string.Empty;
            Console.WriteLine("I Herbivore!");
        }
        public Herbivore(string name) : base()
        {
            Name = name;
            Console.WriteLine($"I Herbivore with a name: {Name}!");
        }
        private string Name { get; }
    }
}
