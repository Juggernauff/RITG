using System;

namespace RITG.Task1
{
    internal class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public void GetInfo(IInformative item) =>
            item.ShowInfo();
        public void CheckItems(IStorable item) =>
            item.ShowItems();
        public void PutItem(IStorable item, Item other) =>
            item.AddItem(other);
    }
}
