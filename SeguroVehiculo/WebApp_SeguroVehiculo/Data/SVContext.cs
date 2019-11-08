using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_SeguroVehiculo.Models;

namespace WebApp_SeguroVehiculo.Data
{
    public class SVContext : DbContext
    {
        public DbSet<Person> Person { get; set; }

        public SVContext(DbContextOptions<SVContext> options) : base(options)
        {
        }
    }
}
