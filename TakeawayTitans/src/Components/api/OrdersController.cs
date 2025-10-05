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

        [HttpPost("additem")]
        public async Task<IActionResult> AddItem(OrderItemCreateDto dto)
        {
            var orderItem = new OrderItem
            {
                MenuItemId = dto.MenuItemId,
                Quantity = dto.Quantity,
                Customization = dto.Customization
            };

            _context.OrderItems.Add(orderItem);
            await _context.SaveChangesAsync();

            return Ok(orderItem);
        }
    }
}

