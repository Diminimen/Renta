using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RentShoppingCenter
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Pavilions> Pavilions { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
        public virtual DbSet<ShoppingCenter> ShoppingCenter { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tenant> Tenant { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Rent)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pavilions>()
                .HasMany(e => e.Rent)
                .WithRequired(e => e.Pavilions)
                .HasForeignKey(e => e.EmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pavilions>()
                .HasMany(e => e.ShoppingCenter)
                .WithRequired(e => e.Pavilions)
                .HasForeignKey(e => e.NunberOfFloors)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShoppingCenter>()
                .Property(e => e.ValueAddedRatio)
                .HasPrecision(2, 1);

            modelBuilder.Entity<ShoppingCenter>()
                .Property(e => e.Image)
                .IsFixedLength();

            modelBuilder.Entity<Tenant>()
                .HasMany(e => e.Rent)
                .WithRequired(e => e.Tenant)
                .WillCascadeOnDelete(false);
        }
    }
}
