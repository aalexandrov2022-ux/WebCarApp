using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCarApp.Infrastructure.Data.Domain
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string Model { get; set; } = "";

        public string Picture { get; set; } = "";

        public decimal Price { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }.
}
