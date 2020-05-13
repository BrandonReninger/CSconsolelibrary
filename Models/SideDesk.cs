using System;
using System.Collections.Generic;

namespace console_library.Models
{
    public class SideDesk
    {
        public List<Item> Inventory { get; private set; } = new List<Item>();

        public SideDesk()
        {
            Item popularscience = new Item("Popular Science", 4.99m, 6);
            Item battlefield5 = new Item("Battlefield 5", 29.99m, 3);
            Item guinnessdraught = new Item("Guinness Draught", 1.99m, 50);
            Item katana = new Item("Katana", 500.00m, 10);
            Item fakelibrarycard = new Item("Fake Library Card", 999.99m, 2);
            Inventory.Add(popularscience);
            Inventory.Add(battlefield5);
            Inventory.Add(guinnessdraught);
            Inventory.Add(katana);
            Inventory.Add(fakelibrarycard);
        }
        internal void VisitSideDesk()
        {
            System.Console.WriteLine("Wilkommen to the secret library stash, buy whatevs you want mang.");
            PrintItems();
            bool buying = true;

            while (buying)
            {
                System.Console.WriteLine("Type in precisely the item you'd like to buy or type \"leave\" to exit side desk");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "leave")
                {
                    System.Console.WriteLine("Welp see you later, don't tell anyone about our illegal inventory.");
                    buying = false;
                }
                else
                {
                    PurchaseItem(choice);
                }
            }
        }

        private void PurchaseItem(string itemName)
        {
            Item foundItem = Inventory.Find(item => item.Title.ToLower() == itemName.ToLower());
            if (foundItem != null)
            {
                if (foundItem.Quantity < 1)
                {
                    System.Console.WriteLine($"Sorry we're all outta {foundItem.Title}.");
                    return;
                }
                foundItem.Quantity--;
                System.Console.WriteLine($"You bought {foundItem.Title} for {foundItem.Price}, there's {foundItem.Quantity} left.");
            }
            else
            {
                System.Console.WriteLine($"What is {itemName}?");
            }
        }

        public void PrintItems()
        {
            System.Console.WriteLine("In stock items:");
            for (int i = 0; i < Inventory.Count; i++)
            {
                Item item = Inventory[i];
                if (item.Quantity > 0)
                {
                    Console.WriteLine($"{i + 1} - {item.Title}");
                }
            }
        }
    }
}