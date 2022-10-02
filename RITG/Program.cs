using System;

namespace RITG
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Task3.Cow cow1 = new Task3.Cow();
            cow1.Sound();
            Console.WriteLine();
            Task3.Cow cow2 = new Task3.Cow("Бурка");
            cow2.Sound();
            Console.WriteLine();
            Task3.Herbivore cow3 = new Task3.Cow();
            cow3.Sound();
            Console.WriteLine();
            Task3.Tiger tiger1 = new Task3.Tiger(10);
            tiger1.Attack();
            tiger1.Sound();
            Console.WriteLine();
            Task3.Predator tiger2 = new Task3.Tiger(11);
            tiger2.Attack();
            tiger2.Sound();
        }
    }
}

#region Task1
/*Task1.Person person = new Task1.Person("Danila");
Task1.Box box = new Task1.Box("Drawer", "A drawer that can store things.");
Task1.Box box1 = new Task1.Box("Box", "A small jewelry box.");
person.GetInfo(box);
Console.WriteLine();
person.CheckItems(box);
person.PutItem(box, box1);
person.CheckItems(box);*/
#endregion
#region Task2
/*Task2.Person[] people = {
    new Task2.Person("Ковалёв", "Нелли", "Натанович"),
    new Task2.Person("Князев", "Иосиф", "Святославович"),
    new Task2.Person("Калинин", "Севастьян", "Ростиславович") };

if (Sorting.CheckSortOrder(people))
    Console.WriteLine($"Массив people типа {nameof(Task2.Person)} отсортирован по возрастанию (ascending)!");
else
    Console.WriteLine($"Массив people типа {nameof(Task2.Person)} НЕ отсортирован по возрастанию (ascending)!");

Sorting.Swap(ref people[0], ref people[1]);

if (Sorting.CheckSortOrder(people))
    Console.WriteLine($"Массив people типа {nameof(Task2.Person)} отсортирован по возрастанию (ascending)!");
else
    Console.WriteLine($"Массив people типа {nameof(Task2.Person)} НЕ отсортирован по возрастанию (ascending)!");
}*/
#endregion