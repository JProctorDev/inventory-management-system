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
}