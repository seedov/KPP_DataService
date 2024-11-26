using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SAE.KPP.DataProvider.Models;

namespace SAE.KPP.DataProvider
{
    public class KppDataContext:DbContext
    {
        public KppDataContext(DbContextOptions<KppDataContext> options) : base(options) { }

        public DbSet<User>  Clients { get; set; }
        public DbSet<Payment>   Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Payment>().ToTable("Payments");
        }

    }
}
