using System;
using System.Collections.Generic;

namespace RITG.Task1
{
    internal class Box : Item, IStorable
    {
        public Box(string name, string description)
        {
            Name = name;
            Description = description;
            Items = new List<Item>();
        }
        private List<Item> Items { get; }

        public void AddItem(Item item)
        {
            if (this.Equals(item))
                throw new ArgumentException("You can't put an object in yourself!");
            Items.Add(item);
        }
        public void ShowItems()
        {
            if (Items.Count.Equals(0))
            {
                Console.WriteLine("The box is empty.");
                return;
            }
            foreach (var item in Items)
                item.ShowInfo();
        }
    }
}
