using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InventoryManagementSystem.Models;
using System.ComponentModel;

namespace InventoryManagementSystem.Services;

public class InventoryService
{
    public BindingList<InventoryItem> Inventory { get; } = new();

    private int nextId = 1;

    public void AddItem(InventoryItem item)
    {
        item.Id = nextId++;
        Inventory.Add(item);
    }

    // Updates the values of an existing inventory item.
    public void UpdateItem(
    InventoryItem item,
    string sku,
    string name,
    string category,
    int quantity,
    decimal unitPrice)
    {
        item.Sku = sku;
        item.Name = name;
        item.Category = category;
        item.Quantity = quantity;
        item.UnitPrice = unitPrice;

        // Notify the DataGridView that the item's values changed.
        Inventory.ResetBindings();
    }

    // Removes an inventory item from the collection.
    public void DeleteItem(InventoryItem item)
    {
        Inventory.Remove(item);
    }

    public bool SkuExists(string sku, InventoryItem? ignoreItem = null)
    {
        return Inventory.Any(item =>
            item != ignoreItem &&
            item.Sku.Equals(sku, StringComparison.OrdinalIgnoreCase));
    }
}