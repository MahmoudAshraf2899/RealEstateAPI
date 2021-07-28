using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Real_Estate_System.Models
{
    public class Employess_and_workers
    {
        public int Id { get; set; }

        [Required]
        public int Age { get; set; }
       
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public int Phone { get; set; }
        
        [Required]
        public double Salary { get; set; }
       
        [Required]
        public string FullName { get; set; }
                              
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

    }
}
