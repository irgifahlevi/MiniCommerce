using Microsoft.EntityFrameworkCore;
using MiniCommerceWeb.Data;
using MiniCommerceWeb.Data.Implements;
using MiniCommerceWeb.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// configure db
var conString = builder.Configuration.GetConnectionString("DB");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(conString));

// configure repository
builder.Services.AddScoped<ICategory, CategoryRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
