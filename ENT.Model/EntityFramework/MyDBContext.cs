using ENT.Model.Category;
using ENT.Model.Services;
using ENT.Model.SubCategory;
using ENT.Model.Otp;
using ENT.Model.Users;
using ENT.Model.Cart;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.ServiceAreaMapping;
using ENT.Model.ServiceCartMapping;
using ENT.Model.UserCartMapping;

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
         // optionsBuilder.UseSqlServer("Server= MOHSINMOMIN\\SQLEXPRESS; Database= MyDb; Integrated Security=True; Encrypt=false;");
                        
          //optionsBuilder.UseSqlServer("Server= MOHSINMOMIN\\SQLEXPRESS; Database= MyDb; Integrated Security=True; Encrypt=false;");
        
            //optionsBuilder.UseSqlServer("Server= (localdb)\\MSSQLLocalDB; Database= MyDB; Integrated Security=True; Encrypt=false;");
            //  optionsBuilder.UseSqlServer("Server= (localdb)\\MSSQLLocalDB; Database= MyDb; Integrated Security=True; Encrypt=false;");

            //NENCY
            optionsBuilder.UseSqlServer("Server= NENCY-PATEL21\\SQLEXPRESS; Database= MyDB; Integrated Security=True; Encrypt=false;");

          //optionsBuilder.UseSqlServer("Server= MOHSINMOMIN\\SQLEXPRESS; Database= MyDb; Integrated Security=True; Encrypt=false;");
                    
            optionsBuilder.UseSqlServer("Server=DESKTOP-05KIL3J; Database= MyDb; Integrated Security=True; Encrypt=false;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<UserModel>().ToTable("TblUsers");
            modelBuilder.Entity<ServiceAreaMappingModel>().ToTable("TblServiceAreaMappings");
            modelBuilder.Entity<CategoryModel>().ToTable("TblCategorys");
            modelBuilder.Entity<SubCategoryModel>().ToTable("TblSubCategorys");
            modelBuilder.Entity<ServicesModel>().ToTable("TblServices");
            modelBuilder.Entity<CartModel>().ToTable("TblCarts");
            modelBuilder.Entity<ServiceCartMappingModel>().ToTable("TblServiceCartMappings");
            modelBuilder.Entity<UserCartMappingModel>().ToTable("TblUserCartMappings");
            modelBuilder.Entity<OtpModel>().ToTable("TblOtp");
        }

        public DbSet<UserModel> TblUsers { get; set; }
        public DbSet<ServiceAreaMappingModel> TblServiceAreaMappings { get; set; }
        public DbSet<CategoryModel> TblCategorys { get; set; }
        public DbSet<SubCategoryModel> TblSubCategorys { get; set; }
        public DbSet<ServicesModel> TblServices { get; set; }
        public DbSet<CartModel> TblCarts { get; set; }
        public DbSet<ServiceCartMappingModel> TblServiceCartMappings { get; set; }
        public DbSet<UserCartMappingModel> TblUserCartMappings {  get; set; }
        public DbSet<OtpModel> TblOtp {  get; set; }
    }
}
