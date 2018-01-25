using ConsoleApp9.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Territory> Territory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
            modelBuilder.Configurations.Add(new UserPostConfiguration());
            modelBuilder.Configurations.Add(new GroupPostConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
            modelBuilder.Configurations.Add(new UserPostConfiguration());
            modelBuilder.Configurations.Add(new GroupPostConfiguration());
            modelBuilder.Configurations.Add(new CommentForUserPostConfiguration());
            modelBuilder.Configurations.Add(new CommentForGroupPostConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public ApplicationDbContext() : base("name=ConnectionString")
        {

        }
    }
}
