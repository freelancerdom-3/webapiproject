using ENT.Model.Category;
using ENT.Model.Services;
using ENT.Model.SubCategory;
using ENT.Model.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.ServiceAreaMapping;

namespace ENT.Model.EntityFramework
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> option) : base(option)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //General-connection string
            //optionsBuilder.UseSqlServer("Server= (localdb)\\MSSQLLocalDB; Database= MyDb; Integrated Security=True; Encrypt=false;");

            //Hemil-Fichadia
            //optionsBuilder.UseSqlServer(@"Server= (localdb)\MSSQLLocalDB; Database= MyDb; Integrated Security=True; Encrypt=false;");
            
            //optionsBuilder.UseSqlServer("Server= (localdb)\\MSSQLLocalDB; Database= MyDb; Integrated Security=True; Encrypt=false;");
          optionsBuilder.UseSqlServer("Server= MOHSINMOMIN\\SQLEXPRESS; Database= MyDb; Integrated Security=True; Encrypt=false;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<UserModel>().ToTable("TblUsers");
            modelBuilder.Entity<ServiceAreaMappingModel>().ToTable("TblServiceAreaMappings");
            modelBuilder.Entity<CategoryModel>().ToTable("TblCategorys");
            modelBuilder.Entity<SubCategoryModel>().ToTable("TblSubCategorys");
            modelBuilder.Entity<ServicesModel>().ToTable("TblServices");
        }

        public DbSet<UserModel> TblUsers { get; set; }
        public DbSet<ServiceAreaMappingModel> TblServiceAreaMappings { get; set; }
        public DbSet<CategoryModel> TblCategorys { get; set; }
        public DbSet<SubCategoryModel> TblSubCategorys { get; set; }
        public DbSet<ServicesModel> TblServices { get; set; }
    }
}
