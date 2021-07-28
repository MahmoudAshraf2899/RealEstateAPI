using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Real_Estate_System.Models
{
    public class RealStateDbContext:IdentityDbContext<IdentityUser>
    {
        public RealStateDbContext(DbContextOptions<RealStateDbContext> options):base(options)
        {
        }
        public DbSet<Sales> Sallers{ get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Employess_and_workers> employess_And_Workers { get; set; }
        public DbSet<Dublex> Dublexes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<CallCenter> CallCenters { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


    }
}
