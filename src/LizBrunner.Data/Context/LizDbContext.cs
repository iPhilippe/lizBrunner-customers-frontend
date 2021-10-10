using LizBrunner.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizBrunner.Data.Context
{
    public class LizDbContext : DbContext
    {


        public LizDbContext(DbContextOptions options) : base(options)
        {


        }

        public DbSet<Client> Clients { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(150)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LizDbContext).Assembly);

            base.OnModelCreating(modelBuilder);

        }

    }
}
