﻿using RITG.Task2;
using System;

namespace RITG
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Person[] people = {
                new Person("Ковалёв", "Нелли", "Натанович"),
                new Person("Князев", "Иосиф", "Святославович"),
                new Person("Калинин", "Севастьян", "Ростиславович") };

            if (Sorting.CheckSortOrder(people))
                Console.WriteLine($"Массив people типа {nameof(Person)} отсортирован по возрастанию (ascending)!");
            else
                Console.WriteLine($"Массив people типа {nameof(Person)} НЕ отсортирован по возрастанию (ascending)!");

            Sorting.Swap(ref people[0], ref people[1]);

            if (Sorting.CheckSortOrder(people))
                Console.WriteLine($"Массив people типа {nameof(Person)} отсортирован по возрастанию (ascending)!");
            else
                Console.WriteLine($"Массив people типа {nameof(Person)} НЕ отсортирован по возрастанию (ascending)!");
        }
    }
}