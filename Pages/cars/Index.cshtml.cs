using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarRental.Data;
using CarRental.Pages.Models;

namespace CarRental.Pages.cars
{
    public class IndexModel : PageModel
    {
        private readonly CarRental.Data.CarRentalContext _context;

        public IndexModel(CarRental.Data.CarRentalContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Models { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CarModel { get; set; }

        public async Task OnGetAsync()
        {
            var cars = from c in _context.Car
                         select c;
            if (!string.IsNullOrEmpty(SearchString))
            {
                cars = cars.Where(s => s.Model.Contains(SearchString));
            }
            Car = await _context.Car.ToListAsync();
        }
    }
}
