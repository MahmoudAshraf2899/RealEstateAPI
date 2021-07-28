using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Real_Estate_System.Models
{
    public class Dublex
    {
        public int Id { get; set; }

        [Required]
        public double Area { get; set; }
        [Required]
        public double Price { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public int Phone { get; set; }

        [Required]
        public string Payment { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Informations { get; set; }
        public string ImageUrl { get; set; }
        public Sales Sales { get; set; }


    }
}
