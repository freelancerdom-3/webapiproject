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
using ENT.Model.Offer;
using ENT.Model.CustomModel;
using ENT.Model.Area;
using ENT.Model.City;
using ENT.Model.State;
using ENT.Model.Country;
using ENT.Model.ServiceProviderAreaMapping;
using ENT.Model.ServiceProviderSubCategoryMapping;
using ENT.Model.ImageNames;
using ENT.Model.TimeSlots;
using ENT.Model.Fees;


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
            optionsBuilder.UseSqlServer(@"Server= LAPTOP-LHKLMKKD\SQLEXPRESS; Database= MyDb; Integrated Security=True; Encrypt=false;");
            

            //NENCY
            //optionsBuilder.UseSqlServer("Server= NENCY-PATEL21\\SQLEXPRESS; Database= MyDB; Integrated Security=True; Encrypt=false;");

            //Alpesh-Gami          
            //optionsBuilder.UseSqlServer("Server=DESKTOP-05KIL3J; Database= MyDb; Integrated Security=True; Encrypt=false;");
            
            //Mohsin-Ali-Momin
            //optionsBuilder.UseSqlServer("Server= MOHSINMOMIN\\SQLEXPRESS; Database= MyDb; Integrated Security=True; Encrypt=false;");
                   
          
        
            //optionsBuilder.UseSqlServer("Server= (localdb)\\MSSQLLocalDB; Database= MyDB; Integrated Security=True; Encrypt=false;");
            //  optionsBuilder.UseSqlServer("Server= (localdb)\\MSSQLLocalDB; Database= MyDb; Integrated Security=True; Encrypt=false;");

            //NENCY
            //optionsBuilder.UseSqlServer("Server= NENCY-PATEL21\\SQLEXPRESS; Database= MyDB; Integrated Security=True; Encrypt=false;");

                    
           // optionsBuilder.UseSqlServer("Server=DESKTOP-05KIL3J; Database= MyDb; Integrated Security=True; Encrypt=false;");
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
            modelBuilder.Entity<OfferModel>().ToTable("TblOffers");
            modelBuilder.Entity<AreaModel>().ToTable("TblAreas");
            modelBuilder.Entity<CityModel>().ToTable("TblCities");
            modelBuilder.Entity<StateModel>().ToTable("TblStates");
            modelBuilder.Entity<CountryModel>().ToTable("TblCountries");
            modelBuilder.Entity<ServiceProviderAreaMappingModel>().ToTable("TblServiceProviderAreaMapping");
            modelBuilder.Entity<ServiceProviderSubCategoryMappingModel>().ToTable("TblServiceProviderSubCategoryMapping");
            modelBuilder.Entity<ImageNameModel>().ToTable("TblImageNames");
            modelBuilder.Entity<TimeSlotsModel>().ToTable("TblTimeSlots");
            modelBuilder.Entity<FeesModel>().ToTable("TblFees");
            
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
        public DbSet<OfferModel> TblOffers { get; set; }
        public DbSet<ServiceSubCatagoryNameViewModel> ServiceSubCatagoryNameViewModel { get; set; }
        public DbSet<GetAreaBySearchViewModel> GetAreaBySearchViewModel { get; set; }
        public DbSet<AreaModel> TblAreas { get; set; }
        public DbSet<CityModel> TblCities { get; set; }
        public DbSet<StateModel> TblStates { get; set; }
        public DbSet<CountryModel> TblCountries { get; set; }
        public DbSet<ServiceProviderSubCategoryMappingModel> TblServiceProviderSubCategoryMapping { get; set; }

        public DbSet<ServiceProviderSubCategoryMappingViewModel> ServiceProviderSubCategoryMappingViewModel {  get; set; }
        public DbSet<ServiceProviderAreaMappingModel> TblServiceProviderAreaMapping { get; set; }
        public DbSet<SubCategoryNameViewModel> SubCategoryNameViewModels { get; set; }
        public DbSet<ServicesBySearchViewModel> ServicesBySearchViewModel { get; set; }
        public DbSet<ChildSubCategoryNameViewModel> childSubCategoryNameViewModels { get; set; }
        public DbSet<ImageNameModel> TblImageNames { get; set; }
        public DbSet<ServiceNameViewModel> ServiceNameViewModels { get; set; }
        public DbSet<TimeSlotsModel> TblTimeSlots { get; set; }
        public DbSet<FeesModel> TblFees { get; set; }
       
        public DbSet<SubCategoryImageNameViewModel> SubCategoryImageNameViewModels { get; set; }
    }
}
