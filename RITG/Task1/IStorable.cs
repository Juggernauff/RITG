using System.Collections.Generic;

namespace RITG.Task1
{
    internal interface IStorable
    {
        private List<Item> Items => new List<Item>();
        public void AddItem(Item item);
        public void ShowItems();
    }
}
