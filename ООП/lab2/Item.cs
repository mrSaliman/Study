using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Item
    {
        public string Name;
        public int Count;
        public double ItemCost;

        public Item(string name, int count, double itemCost)
        {
            this.Name = name;
            this.Count = count;
            this.ItemCost = itemCost;
        }

        public static void ConsolePrint(Item item)
        {
            Console.WriteLine($"{item.Name} {item.Count} {item.ItemCost}");
        }

        public static Item operator +(Item item, int count)
        {
            return new Item (item.Name, count + item.Count, item.ItemCost);
        }

        public static Item operator +(int count, Item item)
        {
            return new Item(item.Name, count + item.Count, item.ItemCost);
        }

        public static Item operator *(int discount, Item item)
        {
            return new Item(item.Name, item.Count, item.ItemCost * discount);
        }

        public static Item operator *(Item item, int discount)
        {
            return new Item(item.Name, item.Count, item.ItemCost * discount);
        }

        public static Item operator +(Item item1, Item item2)
        {
            return new Item(item1.Name + "_" + item2.Name, item1.Count + item2.Count, (item1.ItemCost + item2.ItemCost) / 2);
        }

        public static bool operator !=(Item item1, Item item2)
        {
            return (item1.Name != item2.Name) || (item1.Count != item2.Count) || (item1.ItemCost != item2.ItemCost);
        }

        public static bool operator ==(Item item1, Item item2)
        {
            return (item1.Name == item2.Name) && (item1.Count == item2.Count) && (item1.ItemCost == item2.ItemCost);
        }
    }
}
