using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;

namespace InventoryManagementSystem;

// Main application window for the Inventory Management System.
public partial class MainForm : Form
{
    // Service responsible for managing inventory data and business logic.
    private readonly InventoryService inventoryService = new();

    public MainForm()
    {
        // Initialize all controls created in the Windows Forms Designer.
        InitializeComponent();

        // Populate the category drop-down with predefined product categories.
        cmbCategory.Items.AddRange(new string[]
        {
            "Electronics",
            "Office Supplies",
            "Furniture",
            "Appliances",
            "Accessories"
        });

        // Select the first category by default.
        cmbCategory.SelectedIndex = 0;

        // Bind the DataGridView to the inventory collection.
        dgvInventory.DataSource = inventoryService.Inventory;

    }

    // Runs when the main form finishes loading.
    private void MainForm_Load(object sender, EventArgs e)
    {
        // Additional startup code can be placed here later.
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        // Create an inventory item from the form inputs.
        InventoryItem item = new()
        {
            Sku = txtSku.Text,
            Name = txtName.Text,
            Category = cmbCategory.Text,
            Quantity = (int)nudQuantity.Value,
            UnitPrice = nudPrice.Value
        };

        // Add the item to the inventory collection.
        inventoryService.AddItem(item);

        // Clear the input fields.
        txtSku.Clear();
        txtName.Clear();
        cmbCategory.SelectedIndex = 0;
        nudQuantity.Value = 0;
        nudPrice.Value = 0;

        txtSku.Focus();
    }
}
