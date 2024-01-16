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
        private Dictionary<int, int> _inventory = new Dictionary<int, int>();
        private List<int> _items = new List<int>();
        
        ItemDatabase ItemDatabaseReference = new ItemDatabase();

        private int _equippedItem;

        private int _equippedHelmet;
        private int _equippedChestplate;
        private int _equippedLeggings;
        public void PrintInventory()
        {
            foreach (var item in _inventory)
            {
                Console.Write("| " + item.Value + "x " + ItemDatabaseReference.itemDatabase.FirstOrDefault(itemName => itemName.ItemID == item.Key).Name + " | ");
            }
        }
        public void PrintItemInfo(int itemId) // Use for testing
        {
            Item itemToPrint = ItemDatabaseReference.itemDatabase.FirstOrDefault(item => item.ItemID == itemId);
            Console.WriteLine(itemToPrint.Name);
        }
        private bool isInventoryInitalized = false;
        public void InitializeInventory()
        {
            if (isInventoryInitalized)
                return;
            AddItem(1); // Basic Sword
            AddItem(2, 5); // Potion
            AddItem(3); // Modern Hat
            AddItem(4); // T-Shirt
            AddItem(5); // Jeans

            EquipItem("Item", 1);
            EquipItem("Helmet", 3);
            EquipItem("Chestplate", 5);
            EquipItem("Leggings", 4);
            isInventoryInitalized = true;
        }
        public void AddItem(int itemId, int quantity = 1)
        {
            if (!_inventory.ContainsKey(itemId))
                _inventory.Add(itemId, quantity);
            else
                _inventory[itemId] += quantity;
        }
        public void RemoveItem(int itemId, int quantity = 1)
        {
            if (!_inventory.ContainsKey(itemId))
                return;
            _inventory[itemId] -= quantity;
            if (!(_inventory[itemId] <= 0))
                return;
            _inventory.Remove(itemId);
        }
        public void EquipItem(string itemType, int itemId)
        {
            StatsUpdate statsUpdate = new StatsUpdate();
            
            Item itemToEquip = ItemDatabaseReference.itemDatabase.FirstOrDefault(item => item.ItemID == itemId);
            
            if (!_inventory.ContainsKey(itemId))
                return;
            switch (itemType.ToLower())
            {
                case "helmet":
                    if (_equippedHelmet == itemId)
                        break;
                    Console.WriteLine(_equippedHelmet.ToString());
                    _items.Remove(_equippedHelmet);
                    if(_equippedHelmet != 0)
                        _inventory.Add(_equippedHelmet, 1);
                    statsUpdate.AddHelmetStats(itemToEquip as HelmetBase);
                    _equippedHelmet = itemId;
                    statsUpdate.AddHelmetStats(itemToEquip as HelmetBase);
                    _items.Add(_equippedHelmet);
                    _inventory.Remove(_equippedHelmet);
                    break;
                case "chestplate":
                    if (_equippedChestplate == itemId)
                        break;
                    _items.Remove(_equippedChestplate);
                    if(_equippedChestplate != 0)
                        _inventory.Add(_equippedChestplate, 1);
                    statsUpdate.AddChestplateStats(itemToEquip as ChestplateBase);
                    _equippedChestplate = itemId;
                    statsUpdate.RemoveChestplateStats(itemToEquip as ChestplateBase);
                    _items.Add(_equippedChestplate);
                    _inventory.Remove(_equippedChestplate);
                    break;
                case "leggings":
                    if (_equippedLeggings == itemId)
                        break;
                    _items.Remove(_equippedLeggings);
                    if (_equippedLeggings != 0)
                        _inventory.Add(_equippedLeggings, 1);
                    statsUpdate.AddLeggingsStats(itemToEquip as LeggingsBase);
                    _equippedLeggings = itemId;
                    statsUpdate.RemoveLeggingsStats(itemToEquip as LeggingsBase);
                    _items.Add(_equippedLeggings);
                    _inventory.Remove(_equippedLeggings);
                    break;
                case "item":
                    if (_equippedItem == itemId)
                        break;
                    _items.Remove(_equippedItem);
                    if(_equippedLeggings != 0)
                        _inventory.Add(_equippedItem, 1);
                    if(itemToEquip != null && itemToEquip.ItemType == Item.ItemTypes.Weapon)
                        statsUpdate.RemoveDamage(itemToEquip as WeaponBase);
                    _equippedItem = itemId;
                    if(itemToEquip != null && itemToEquip.ItemType == Item.ItemTypes.Weapon)
                        statsUpdate.AddDamage(itemToEquip as WeaponBase);
                    _items.Add(_equippedItem);
                    _inventory.Remove(_equippedItem);
                    break;
                default:
                    throw new Exception($"Can't equip item type {itemType}");
            }
        }

        public string PrintItemName(string itemType)
        {
            switch (itemType.ToLower())
            {
                case "item":
                    return ItemDatabaseReference.itemDatabase.FirstOrDefault(item => item.ItemID == _equippedItem).Name;
                    break;
                case "helmet":
                    return ItemDatabaseReference.itemDatabase.FirstOrDefault(item => item.ItemID == _equippedHelmet).Name;
                    break;
                case "chestplate":
                    return ItemDatabaseReference.itemDatabase.FirstOrDefault(item => item.ItemID == _equippedChestplate).Name;
                    break;
                case "leggings":
                    return ItemDatabaseReference.itemDatabase.FirstOrDefault(item => item.ItemID == _equippedLeggings).Name;
                    break;
                default:
                    throw new Exception($"Invalid equip to return {itemType}");
            }
        }
    }
}
