using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Pages.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string ImageSrc { get; set; }
        public int Doors { get; set; }
        public int seats { get; set; }
        public bool automatic { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
