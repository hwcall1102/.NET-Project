using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantApi.Models;

namespace TakeawayTitans.Data
{
    public class TakeawayTitansContext : DbContext
    {
        public TakeawayTitansContext (DbContextOptions<TakeawayTitansContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantApi.Models.MenuItem> MenuItem { get; set; } = default!;
    }
}
