using TakeawayTitans.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeawayTitans.Services
{
    public class ShoppingCartService
    {
        public event Action OnChange;  // Event to notify components

        public List<CartItemDto> Items { get; set; } = new();

        public void AddItem(CartItemDto item)
        {
            var existing = Items.FirstOrDefault(i => i.MenuItemId == item.MenuItemId);
            if (existing != null)
                existing.Quantity += item.Quantity;
            else
                Items.Add(item);
            NotifyStateChanged();
        }

        public void UpdateItem(CartItemDto item)
        {
            var existing = Items.FirstOrDefault(i => i.MenuItemId == item.MenuItemId);
            if (existing != null)
            {
                existing.Quantity = item.Quantity;
                existing.Customization = item.Customization;
                NotifyStateChanged();
            }
        }

        public void RemoveItem(CartItemDto item)
        {
            Items.RemoveAll(i => i.MenuItemId == item.MenuItemId);
            NotifyStateChanged();
        }

        public void Clear()
        {
            Items.Clear();
            NotifyStateChanged();
        }

        public decimal Total() => Items.Sum(i => i.Price * i.Quantity);

        private void NotifyStateChanged()
        {
            Console.WriteLine($"Cart changed: {Items.Count} items, total = {Total():C}");
            OnChange?.Invoke();
        }

    }
}
