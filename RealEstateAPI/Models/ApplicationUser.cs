using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Real_Estate_System.Models
{
    public class ApplicationUser:IdentityUser
    {
        [DisplayName("Phone Number2")]
        public string PhoneNumber2 { get; set; }

        [NotMapped]
        public bool IsAdmin { get; set; }
        [NotMapped]
        public bool IsSales { get; set; }
        [NotMapped]
        public bool salesMember { get; set; }

        [NotMapped]
        public bool IsEngineer { get; set; }
        [NotMapped]
        public bool engineerMember { get; set; }
        [NotMapped]
        public bool IsCallCenter { get; set; }
        [NotMapped]
        public bool callcenterMember { get; set; }
        [NotMapped]
        public bool IsWorkers { get; set; }


    }
}
