using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TakeawayTitans.Data;
using TakeawayTitans.Data.Models;
using TakeawayTitans.Dto;

namespace TakeawayTitans.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuItemsController : ControllerBase
    {
        private readonly TakeawayTitansContext _context;

        public MenuItemsController(TakeawayTitansContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<MenuItemDto>>> GetMenuItems()
        {
            var items = await _context.MenuItems
                .Select(m => new MenuItemDto
                {
                    Id = m.Id,
                    Name = m.Name,
                    Description = m.Description,
                    Price = m.Price,
                    ImageUrl = m.ImageUrl
                })
                .ToListAsync();

            return Ok(items);
        }
    }
}
