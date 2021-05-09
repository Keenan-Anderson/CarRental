using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRental.Data;
using CarRental.Pages.Models;

namespace CarRental.Pages.bookings
{
    public class IndexModel : PageModel
    {
        private readonly CarRental.Data.CarRentalContext _context;

        public IndexModel(CarRental.Data.CarRentalContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; }

        public async Task OnGetAsync()
        {
            Booking = await _context.Booking.ToListAsync();
        }
    }
}
