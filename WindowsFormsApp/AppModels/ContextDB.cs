using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Sport.AppModels
{
    public partial class ContextDB : DbContext
    {
        public ContextDB()
            : base("name=ContextDB")
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<PickupPoint> PickupPoints { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductManufacturer> ProductManufacturers { get; set; }
        public virtual DbSet<ProductName> ProductNames { get; set; }
        public virtual DbSet<ProductSupplier> ProductSuppliers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UnitType> UnitTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderStatu>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.OrderStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PickupPoint>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.PickupPoint)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderProducts)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductManufacturer>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductManufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductName>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductSupplier>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnitType>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.UnitType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
