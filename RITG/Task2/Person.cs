using System;

namespace RITG.Task2
{
    internal class Person : IComparable<Person>
    {
        public Person(string lastName, string firstName, string middleName)
        {
            Console.WriteLine($"Вызов конструктора {nameof(Person)}");
            Id = ++NumberPeople;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
        }
        static Person()
        {
            Console.WriteLine($"Вызов статичного конструктора {nameof(Person)}");
            NumberPeople = 0;
        }
        public static int NumberPeople { get; private set; }
        public int Id { get; }
        public string LastName { get; }
        public string FirstName { get; }
        public string MiddleName { get; }

        public int CompareTo(Person other) =>
            Id.CompareTo(other.Id);

    }
}
