using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TakeawayTitans.Data;
using TakeawayTitans.Data.Models;
using TakeawayTitans.Dto;

namespace TakeawayTitans.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly TakeawayTitansContext _context;

        public OrdersController(TakeawayTitansContext context)
        {
            _context = context;
        }

        // Create a new order from the shopping cart
        [HttpPost("checkout")]
        public async Task<IActionResult> Checkout([FromBody] CheckoutDto checkout)
        {
            if (checkout == null || checkout.Items == null || !checkout.Items.Any())
            {
                return BadRequest("Cart is empty.");
            }

            var order = new Order
            {
                CustomerName = checkout.CustomerName,
                CustomerEmail = checkout.CustomerEmail,
                CustomerPhone = checkout.CustomerPhone,
                Status = OrderStatus.Received,
                CreatedAt = DateTime.UtcNow,
            };

            // Add order items
            foreach (var item in checkout.Items)
            {
                order.OrderItems.Add(new OrderItem
                {
                    MenuItemId = item.MenuItemId,
                    Quantity = item.Quantity,
                    Customization = item.Customization
                });
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return Ok(new { order.OrderId });
        }
    }
}
