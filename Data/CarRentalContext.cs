using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRental.Pages.Models;

namespace CarRental.Data
{
    public class CarRentalContext : DbContext
    {
        public CarRentalContext (DbContextOptions<CarRentalContext> options)
            : base(options)
        {
        }

        public DbSet<CarRental.Pages.Models.Car> Car { get; set; }

        public DbSet<CarRental.Pages.Models.Booking> Booking { get; set; }
    }
}
