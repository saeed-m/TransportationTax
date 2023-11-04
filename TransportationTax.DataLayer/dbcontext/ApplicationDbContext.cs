using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportationTax.DomainClasses.Entities;

namespace TransportationTax.DataLayer.dbcontext
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CongestionTax> congestionTaxes { get; set; }

        public DbSet<ExemptVehicle> exemptVehicles { get; set; }

        public DbSet<PayToll> payTolls { get; set; }

        public DbSet<TimeExemption> timeExemptions { get; set; }



    }
}
