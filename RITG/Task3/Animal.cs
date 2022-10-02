using System;

namespace RITG.Task3
{
    internal abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("I Animal!");
        }
        public abstract void Sound();
    }
}
