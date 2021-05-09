using CarRental.Data;
using CarRental.Pages.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CarRentalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CarRentalContext>>()))
            {
                // Look for any cars.
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }

                context.Car.AddRange(
                    new Car
                    {
                        Model = "Sedan",
                        ImageSrc = "https://c4.wallpaperflare.com/wallpaper/413/595/829/2014-audi-a8-l-w12-exclusive-concept-blue-audi-sedan-wallpaper-preview.jpg",
                        Doors = 4,
                        seats = 5,
                        automatic = false,
                        Price = 99.99m
                    },

                    new Car
                    {
                        Model = "HatchBack",
                        ImageSrc = "https://c4.wallpaperflare.com/wallpaper/832/475/785/audi-rs4-side-view-black-wallpaper-preview.jpg",
                        Doors = 3,
                        seats = 4,
                        automatic = true,
                        Price = 64.95m
                    },

                     new Car
                     {
                         Model = "SUV",
                         ImageSrc = "https://pxhere.com/en/photo/1447497",
                         Doors = 5,
                         seats = 7,
                         automatic = false,
                         Price = 120m
                     },

                     new Car
                     {
                         Model = "Van",
                         ImageSrc = "https://cdn.pixabay.com/photo/2017/01/23/10/54/van-2002079_960_720.png",
                         Doors = 4,
                         seats = 2,
                         automatic = false,
                         Price = 120m
                     }
                );
                context.SaveChanges();
            }
        }
    }
}