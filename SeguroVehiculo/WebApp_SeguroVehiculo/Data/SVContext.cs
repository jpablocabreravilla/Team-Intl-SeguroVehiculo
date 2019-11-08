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
		public DbSet<Vehicle> Vehicle { get; set; }

		public SVContext(DbContextOptions<SVContext> options) : base(options)
        {
			this.Database.EnsureCreated();  // Verifica que halla BD , si no, la crea (pero no crea migracion, solo la BD).
        }
    }
}
