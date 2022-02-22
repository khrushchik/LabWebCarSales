using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LabWebCars.Models
{
    public class CarsContext:DbContext
    {
        public virtual DbSet<Corporation> Corporations { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public CarsContext(DbContextOptions<CarsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }


    }
}
