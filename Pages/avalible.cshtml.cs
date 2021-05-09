using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRental.Data;
using CarRental.Pages.Models;

namespace CarRental.Pages.Shared
{
    public class avalibleModel : PageModel
    {
        private readonly CarRental.Data.CarRentalContext _context;

        public avalibleModel(CarRental.Data.CarRentalContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }
    }
}
