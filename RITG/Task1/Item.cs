using System;
using System.Collections.Generic;
using System.Text;

namespace RITG.Task1
{
    internal abstract class Item : IInformative
    {
        public string Name { get; protected set; } = string.Empty;
        public string Description { get; protected set; } = string.Empty;
        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name}: {Name}\n" +
                              $"Description: {Description}");
        }
    }
}
