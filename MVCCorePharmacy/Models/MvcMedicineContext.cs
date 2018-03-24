using System;
using Microsoft.EntityFrameworkCore;

namespace MVCCorePharmacy.Models
{
    public class MvcMedicineContext : DbContext
    {
        public MvcMedicineContext(DbContextOptions<MvcMedicineContext> options): base(options){

        }

        public DbSet<Medicine> Medicine { get; set; }
    }
}
