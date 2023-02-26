using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Food2URazor.Models;

namespace Food2URazor.Data
{
    public class Food2URazorContext : DbContext
    {
        public Food2URazorContext (DbContextOptions<Food2URazorContext> options)
            : base(options)
        {
        }

        public DbSet<Food2URazor.Models.Cart> Carts { get; set; } = default!;
        public DbSet<Food2URazor.Models.Driver> Drivers { get; set; } = default!;
        public DbSet<Food2URazor.Models.Item> Items { get; set; } = default!;
        public DbSet<Food2URazor.Models.Menu> Menus { get; set; } = default!;
        public DbSet<Food2URazor.Models.Order> Orders { get; set; } = default!;
        public DbSet<Food2URazor.Models.Restaurant> Restaurants { get; set; } = default!;
        public DbSet<Food2URazor.Models.Shopper> Shoppers { get; set; } = default!;
    }
}
