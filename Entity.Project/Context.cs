using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Project
{
    class Context:DbContext
    {

        public DbSet<Branch>branches { get; set; }
        public DbSet<Department>departments{ get; set; }
        public DbSet<Employee>employees{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-KDJJ2G8;Initial Catalog= EntityCoreDb;Integrated Security=True;");
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Department>().Property(x => x.Name).IsRequired(true);
            modelBuilder.Entity<Attendance>().HasKey(x => new { x.EmpID, x.Date });
            modelBuilder.Entity<Department>().HasQueryFilter(x => !x.Deleted);
            modelBuilder.Entity<Employee>()
                .Property<bool>("Deleted").IsRequired(true)
                .HasDefaultValue(false);
            base.OnModelCreating(modelBuilder);
        }

    }
}
