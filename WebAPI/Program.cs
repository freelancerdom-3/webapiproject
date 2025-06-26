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
using ENT.BL.Offer;
using ENT.BL.Offers;
using ENT.BL.ServiceProviderAreaMapping;
using ENT.BL.ServiceProviderSubCategoryMapping;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using ENT.BL.ImageName;
using ENT.BL.TimeSlots;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddDbContext<MyDBContext>(options => options.UseSqlServer("Server= MOHSINMOMIN\\SQLEXPRESS; Database= MyDb; Integrated Security=True; Encrypt=false;"));
//builder.Services.AddDbContext<MyDBContext>(options => options.UseSqlServer("Server= (localdb)\\MSSQLLocalDB; Database= MyDb; Integrated Security=True; Encrypt=false;"));
//Hemil-Fichadia
builder.Services.AddDbContext<MyDBContext>(options => options.UseSqlServer(@"Server= (localdb)\MSSQLLocalDB; Database= MyDb; Integrated Security=True; Encrypt=false;"));
//Nency-Patel
//builder.Services.AddDbContext<MyDBContext>(options => options.UseSqlServer("Server= NENCY-PATEL21\\SQLEXPRESS; Database= MyDb; Integrated Security=True; Encrypt=false;"));

//Alpesh-Gami
//builder.Services.AddDbContext<MyDBContext>(options => options.UseSqlServer("Server=DESKTOP-05KIL3J; Database= MyDb; Integrated Security=True; Encrypt=false;"));

//builder.Services.AddDbContext<MyDBContext>(options => options.UseSqlServer("Server=DESKTOP-05KIL3J; Database= MyDb; Integrated Security=True; Encrypt=false;"));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//JWT Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options  =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:JwtKey"]))
    };
});

builder.Services.AddAuthorization();

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
builder.Services.AddScoped<IOffer, Offer>();
builder.Services.AddScoped<IServiceProviderAreMapping, ServiceProviderAreaMapping>();
builder.Services.AddScoped<IServiceProviderSubCategoryMapping, ServiceProviderSubCategoryMapping>();
builder.Services.AddScoped<IImageName, ImageName>();
builder.Services.AddScoped<ITimeSlots, TimeSlots>();

builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//To allow any request from front-end to reach back-end
app.UseCors("AllowOrigin");

//JWT
app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
