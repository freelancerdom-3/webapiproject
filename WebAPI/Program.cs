using ENT.BL.Cart;
using ENT.BL.Category;
using ENT.BL.Otp;
using ENT.BL.ServiceAreaMapping;
using ENT.BL.Services;
using ENT.BL.SubCategory;
using ENT.BL.ServiceCartMapping;
using ENT.BL.UserCartMapping;
using ENT.BL.User;
using ENT.Model.EntityFramework;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddDbContext<MyDBContext>(options => options.UseSqlServer("Server= MOHSINMOMIN\\SQLEXPRESS; Database= MyDb; Integrated Security=True; Encrypt=false;"));
//builder.Services.AddDbContext<MyDBContext>(options => options.UseSqlServer("Server= (localdb)\\MSSQLLocalDB; Database= MyDb; Integrated Security=True; Encrypt=false;"));
//Hemil-Fichadia
//builder.Services.AddDbContext<MyDBContext>(options => options.UseSqlServer(@"Server= (localdb)\MSSQLLocalDB; Database= MyDb; Integrated Security=True; Encrypt=false;"));
//Nency-Patel
builder.Services.AddDbContext<MyDBContext>(options => options.UseSqlServer("Server= NENCY-PATEL21\\SQLEXPRESS; Database= MyDb; Integrated Security=True; Encrypt=false;"));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton // one instance per application
builder.Services.AddScoped<IUser, User>(); // one instance, per request value will be assigned
//builder.Services.AddTransient // new instance per request

builder.Services.AddScoped<ICategory, Category>();
builder.Services.AddScoped<ISubCategory, SubCategory>();
builder.Services.AddScoped<IServices, Services>();
builder.Services.AddScoped<IOtp, Otp>();
builder.Services.AddScoped<IServiceAreaMapping, ServiceAreaMapping>();
builder.Services.AddScoped<ICart, Cart>();
builder.Services.AddScoped<IServiceCartMapping , ServiceCartMapping>();
builder.Services.AddScoped<IUserCartMapping, UserCartMapping>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
