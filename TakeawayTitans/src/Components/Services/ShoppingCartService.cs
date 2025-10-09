using TakeawayTitans.Dto;
using System.Collections.Generic;
using System.Linq;

namespace TakeawayTitans.Services
{
    public class ShoppingCartService
    {
        // Holds items in memory per user session (scoped)
        public List<CartItemDto> Items { get; set; } = new();

        public void AddItem(CartItemDto item)
        {
            var existing = Items.FirstOrDefault(x => x.MenuItemId == item.MenuItemId 
                                                    && x.Customization == item.Customization);
            if (existing != null)
            {
                existing.Quantity += item.Quantity;
            }
            else
            {
                Items.Add(item);
            }
        }

        public void RemoveItem(CartItemDto item)
        {
            Items.Remove(item);
        }

        public void Clear() => Items.Clear();

        public decimal Total() => Items.Sum(x => x.Price * x.Quantity);
    }
}
