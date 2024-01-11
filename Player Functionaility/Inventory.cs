using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic_Text_Based_RPG_Epic_Edition_2._0.Items;

namespace Generic_Text_Based_RPG_Epic_Edition_2._0
{
    internal class Inventory
    {
        public Dictionary<int, int> inventory = new Dictionary<int, int>();
        ItemDatabase ItemDatabaseReference = new ItemDatabase();

        public int currentlySelectedItem;

        public int currentlyEquippedHelmet;
        public int currentlyEquippedChestplate;
        public int currentlyEquippedLeggings;
        public void PrintInventory()
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void PrintItemInfo(int itemId) // Use for testing
        {
            Item itemToPrint = ItemDatabaseReference.itemDatabase.FirstOrDefault(item => item.ItemID == itemId);
            Console.WriteLine(itemToPrint.Name);
        }
        public void InitializeInventory()
        {
            AddItem(1); // Basic Sword
            AddItem(2, 5); // Potion
            AddItem(3); // Modern Hat
            AddItem(4); // T-Shirt
            AddItem(5); // Jeans

            EquipItem("Item", 1);
            EquipItem("Helmet", 3);
            EquipItem("Chestplate", 4);
            EquipItem("Leggings", 5);
        }
        public void AddItem(int itemId, int quantity = 1)
        {
            if (inventory.ContainsKey(itemId) == false)
                inventory.Add(itemId, quantity);
            else
                inventory.Add(itemId, inventory[itemId] + quantity);
        }
        public void RemoveItem(int itemId, int quantity = 1)
        {
            if (!inventory.ContainsKey(itemId))
                return;
            inventory.Add(itemId, inventory[itemId] - quantity);
            if (!(inventory[itemId] <= 0))
                return;
            inventory.Remove(itemId);
        }
        public void EquipItem(string itemType, int itemId)
        {
            if (!inventory.ContainsKey(itemId))
                return;
            switch (itemType.ToLower())
            {
                case "helmet":
                    currentlyEquippedHelmet = itemId;
                    break;
                case "chestplate":
                    currentlyEquippedChestplate = itemId;
                    break;
                case "leggings":
                    currentlyEquippedLeggings = itemId;
                    break;
                case "item":
                    currentlySelectedItem = itemId;
                    break;
                default:
                    throw new Exception($"Can't equip item type {itemType}");
            }
        }
    }
}
