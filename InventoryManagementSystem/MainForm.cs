using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;
using InventoryManagementSystem.Helpers;

namespace InventoryManagementSystem;

// Main application window for the Inventory Management System.
public partial class MainForm : Form
{
    // Service responsible for managing inventory data and business logic.
    private readonly InventoryService inventoryService = new();
    // Stores the currently selected inventory item.
    private InventoryItem? selectedItem;

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
        dgvInventory.Columns["Id"].Visible = false;

        // Customize the DataGridView column headers.
        dgvInventory.Columns["Id"].HeaderText = "ID";
        dgvInventory.Columns["Sku"].HeaderText = "SKU";
        dgvInventory.Columns["UnitPrice"].HeaderText = "Unit Price";
        dgvInventory.Columns["TotalValue"].HeaderText = "Total Value";

        // Format currency columns.
        dgvInventory.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";
        dgvInventory.Columns["TotalValue"].DefaultCellStyle.Format = "C2";

    }

    // Runs when the main form finishes loading.
    private void MainForm_Load(object sender, EventArgs e)
    {
        // Additional startup code can be placed here later.
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!ValidationHelper.ValidateItem(
          txtSku.Text,
          txtName.Text,
          (int)nudQuantity.Value,
          nudPrice.Value,
          out string errorMessage))
        {
            MessageBox.Show(
                errorMessage,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        if (inventoryService.SkuExists(txtSku.Text))
        {
            MessageBox.Show(
                "That SKU already exists.",
                "Duplicate SKU",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            txtSku.Focus();
            return;
        }

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
        ClearForm();

    }

    private void dgvInventory_CellContentClick(
    object sender,
    DataGridViewCellEventArgs e)
    {
        // Ignore clicks on the column headers.
        if (e.RowIndex < 0)
        {
            return;
        }

        // Get the selected inventory item.
        selectedItem =
        dgvInventory.Rows[e.RowIndex].DataBoundItem as InventoryItem;

        if (selectedItem is null)
        {
            return;
        }

        // Display the selected item's information.
        txtSku.Text = selectedItem.Sku;
        txtName.Text = selectedItem.Name;
        cmbCategory.Text = selectedItem.Category;
        nudQuantity.Value = selectedItem.Quantity;
        nudPrice.Value = selectedItem.UnitPrice;
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        // Make sure a product has been selected.
        if (selectedItem is null)
        {
            MessageBox.Show(
                "Please select a product to update.",
                "No Product Selected",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        // Validate the user's input.
        if (!ValidationHelper.ValidateItem(
            txtSku.Text,
            txtName.Text,
            (int)nudQuantity.Value,
            nudPrice.Value,
            out string errorMessage))
        {
            MessageBox.Show(
                errorMessage,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        if (inventoryService.SkuExists(txtSku.Text, selectedItem))
        {
            MessageBox.Show(
                "Another product is already using that SKU.",
                "Duplicate SKU",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            txtSku.Focus();
            return;
        }

        // Update the selected product.
        inventoryService.UpdateItem(
            selectedItem,
            txtSku.Text,
            txtName.Text,
            cmbCategory.Text,
            (int)nudQuantity.Value,
            nudPrice.Value);

        // Clear the form after the update.
        ClearForm();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        // Make sure a product has been selected.
        if (selectedItem is null)
        {
            MessageBox.Show(
                "Please select a product to delete.",
                "No Product Selected",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        // Ask the user to confirm the deletion.
        DialogResult result = MessageBox.Show(
            $"Are you sure you want to delete {selectedItem.Name}?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (result != DialogResult.Yes)
        {
            return;
        }

        // Remove the selected product.
        inventoryService.DeleteItem(selectedItem);

        // Clear the selected item reference.
        selectedItem = null;

        // Clear the input controls.
        ClearForm();
    }

    private void ClearForm()
    {
        txtSku.Clear();
        txtName.Clear();
        cmbCategory.SelectedIndex = 0;
        nudQuantity.Value = 0;
        nudPrice.Value = 0;

        selectedItem = null;

        txtSku.Focus();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearForm();
    }

}
