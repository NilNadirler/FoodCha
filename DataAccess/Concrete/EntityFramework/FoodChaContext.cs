using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class FoodChaContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=FoodCha;Trusted_Connection=true");
        }

        public DbSet<EmployeeRepository> Employees { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ProductRepository > Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
        public DbSet<TransactionRepository> Transactions { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserImage> UserImages { get; set; }
        public DbSet<Storage> Storages { get; set; }


    }
}
