using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Real_Estate_System.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public int Phone { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Office Number")]
        public int PhoneNumber { get; set; }

        public double Budget { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Requierments { get; set; }
    }
}
