using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Models
{
    public class HealthcareDbContext : DbContext
    {
        public HealthcareDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }
    }
}
