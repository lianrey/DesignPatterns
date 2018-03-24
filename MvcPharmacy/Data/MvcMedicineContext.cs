using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcPharmacy.Models;

    public class MvcMedicineContext : DbContext
    {
        public MvcMedicineContext (DbContextOptions<MvcMedicineContext> options)
            : base(options)
        {
        }

        public DbSet<MvcPharmacy.Models.Medicine> Medicine { get; set; }
    }
