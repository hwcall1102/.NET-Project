using TakeawayTitans.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakeawayTitans.Services
{
    public class ShoppingCartService
    {
        // Event returns Task to allow async invocation on Blazor UI thread
        public event Func<Task>? OnChange;

        public List<CartItemDto> CartItems { get; private set; } = new();

        // Add a new item or update quantity if it already exists
        public void AddItem(CartItemDto item)
        {
            // Normalize customization for comparison
            string newItemCustomization = item.Customization?.Trim() ?? string.Empty;

            var existing = CartItems.FirstOrDefault(i =>
                i.MenuItemId == item.MenuItemId &&
                (i.Customization?.Trim() ?? string.Empty) == newItemCustomization
            );

            if (existing != null)
            {
                existing.Quantity += item.Quantity;
            }
            else
            {
                // Store trimmed customization to keep consistency
                item.Customization = newItemCustomization;
                CartItems.Add(item);
            }

            _ = NotifyCartChangedAsync();
        }


        // Update an existing cart item (quantity, customization, etc.)
        public void UpdateItem(CartItemDto item)
        {
            var existing = CartItems.FirstOrDefault(i => i.MenuItemId == item.MenuItemId);
            if (existing != null)
            {
                existing.Quantity = item.Quantity;
                existing.Customization = item.Customization;
                _ = NotifyCartChangedAsync();
            }
        }

        // Update entire cart — useful when changing quantities inline
        public void UpdateCart() => _ = NotifyCartChangedAsync();

        // Remove an item from the cart
        public void RemoveItem(CartItemDto item)
        {
            CartItems.RemoveAll(i => i.MenuItemId == item.MenuItemId && i.Customization == item.Customization);
            _ = NotifyCartChangedAsync();
        }

        // Clear all items (e.g., after successful order)
        public void ClearCart()
        {
            CartItems.Clear();
            _ = NotifyCartChangedAsync();
        }

        // Calculate total
        public decimal Total() => CartItems.Sum(i => i.Price * i.Quantity);

        // Async-safe notification
        private async Task NotifyCartChangedAsync()
        {
            Console.WriteLine($"Cart changed: {CartItems.Count} items, total = {Total():C}");

            if (OnChange != null)
            {
                foreach (var handler in OnChange.GetInvocationList().Cast<Func<Task>>())
                {
                    try
                    {
                        await handler();
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine($"Error in cart OnChange handler: {ex.Message}");
                    }
                }
            }
        }
    }
}
