using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Infrastructure
{
    public class DataContext:DbContext
    {
        //defuatl constructor
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Owner>().Property(x => x.ID).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Portfolio>().Property(x => x.ID).HasDefaultValueSql("NEWID()");

        }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Portfolio> Portfolio { get; set; }
    }

}
