using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IShoot.Data;
using System;
using System.Linq;

namespace IShoot.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DataContext>>()))
            {
                // Look for any movies.
                if (context.Photo.Any())
                {
                    return;   // DB has been seeded
                }

                context.Photo.AddRange(
                    new Photo
                    {
                        Description = "When Harry Met Sally",
                        created_at = DateTime.Parse("1989-2-12"),
                        Url = "Romantic Comedy",
                    
                    },

                    new Photo
                    {
                        Description = "Ghostbusters ",
                        created_at = DateTime.Parse("1984-3-13"),
                        Url = "Comedy",
                     
                    },

                    new Photo
                    {
                        Description = "Ghostbusters 2",
                        created_at = DateTime.Parse("1986-2-23"),
                        Url = "Comedy",
                        
                    },

                    new Photo
                    {
                        Description = "Rio Bravo",
                        created_at = DateTime.Parse("1959-4-15"),
                        Url = "Western",
                       
                    }
                );
                context.SaveChanges();
            }
        }
    }
}