using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Helpers;

public static class ValidationHelper
{
    // Validates inventory item input.
    public static bool ValidateItem(
        string sku,
        string name,
        int quantity,
        decimal price,
        out string errorMessage)
    {
        if (string.IsNullOrWhiteSpace(sku))
        {
            errorMessage = "SKU is required.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            errorMessage = "Product name is required.";
            return false;
        }

        if (quantity <= 0)
        {
            errorMessage = "Quantity must be greater than zero.";
            return false;
        }

        if (price <= 0)
        {
            errorMessage = "Price must be greater than zero.";
            return false;
        }

        errorMessage = string.Empty;
        return true;
    }
}
