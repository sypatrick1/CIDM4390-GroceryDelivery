using Microsoft.EntityFrameworkCore;
using Food2URazor.Data;

namespace Food2URazor.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Food2URazorContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<Food2URazorContext>>()))
        {
            if (context == null || context.Shoppers == null)
            {
                throw new ArgumentNullException("Null Food2URazprContext");
            }

            // Look for any shoppers.
            if (context.Shoppers.Any())
            {
                return;   // DB has been seeded
            }

            context.Shoppers.AddRange(
                new Shopper
                {
                    Username = "brendan",
                    Password = "1234",
                    Name = "Brendan Williams",
                    Email = "bwilliams@email.com",
                    Address = "123 Ace Blvd",
                    Phone = 8064565555
                }
            );

            context.Restaurants.AddRange(
                new Restaurant
                {
                    Name = "McDonalds",
                    Address = "456 Zed St",
                    Phone = 8061235555,
                    Menu = new Menu
                    {
                        Name = "McDonalds Menu",
                        Items = new List<Item>
                        {
                            new Item 
                            {
                                Name = "Burger",
                                Description = "Classic Burger",
                                Price = 5.99
                            },
                            new Item 
                            {
                                Name = "Fries",
                                Description = "Classic French Fries",
                                Price = 2.99
                            }
                        } 
                    }
                }
            );
            context.SaveChanges();
        }
    }
}