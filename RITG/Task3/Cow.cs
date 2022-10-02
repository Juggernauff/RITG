using System;

namespace RITG.Task3
{
    internal class Cow : Herbivore
    {
        public Cow()
        {
            Console.WriteLine("I Cow!");
        }
        public Cow(string name) : base(name)
        {

        }
        public override void Sound()
        {
            Console.WriteLine("Му!");
        }
    }
}
