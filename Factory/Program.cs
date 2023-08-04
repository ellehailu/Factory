using Factory.Models;
using Microsoft.EntityFrameworkCore;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<FactoryContext>(DbContextOptions => DbContextOptions.UseMySql(builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"])));
        }
    }
}


