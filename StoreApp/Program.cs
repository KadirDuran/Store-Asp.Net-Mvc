using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.Models;
using Repositories;
using Services.Contracts;
using Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RepositoryContext>(options =>
{ 
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlConntection"),
        b => b.MigrationsAssembly("StoreApp"));
});
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
var app = builder.Build();
app.UseHttpsRedirection();

app.UseRouting();
app.UseStaticFiles();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(name:"Admin",
        areaName:"Admin",
        pattern: "Admin/{Controller=Dashboard}/{action=Index}/{id?}"
        );
    endpoints.MapControllerRoute(name: "default",
    pattern: "{Controller=Home}/{action=Index}/{id?}");

    endpoints.MapRazorPages();
});

app.Run();
