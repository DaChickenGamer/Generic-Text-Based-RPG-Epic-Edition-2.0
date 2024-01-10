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
        public void PrintItemInfo(int itemID) // Use for testing
        {
            Item itemToPrint = ItemDatabaseReference.itemDatabase.FirstOrDefault(item => item.ItemID == itemID);
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
        public void AddItem(int itemID, int quanity = 1)
        {
            if (inventory.ContainsKey(itemID) == false)
                inventory.Add(itemID, quanity);
            else
                inventory.Add(itemID, inventory[itemID] + quanity);
        }
        public void RemoveItem(int itemID, int quanity = 1)
        {
            if (!inventory.ContainsKey(itemID))
                return;
            inventory.Add(itemID, inventory[itemID] - quanity);
            if (!(inventory[itemID] <= 0))
                return;
            inventory.Remove(itemID);
        }
        public void EquipItem(string itemType, int itemID)
        {
            if (!inventory.ContainsKey(itemID))
                return;
            switch (itemType.ToLower())
            {
                case "helmet":
                    currentlyEquippedHelmet = itemID;
                    break;
                case "chestplate":
                    currentlyEquippedChestplate = itemID;
                    break;
                case "leggings":
                    currentlyEquippedLeggings = itemID;
                    break;
                case "item":
                    currentlySelectedItem = itemID;
                    break;
                default:
                    throw new Exception($"Can't equip item type {itemType}");
            }
        }
    }
}
