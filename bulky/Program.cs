using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using bulky.Data;
using bulky.Injection;
using bulky.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ITestInjection,TestInjection>();
builder.Services.AddDbContext<bulkyContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("bulkyContext") ?? throw new InvalidOperationException("Connection string 'bulkyContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using ( var scope = app.Services.CreateScope()){
    var service_provider = scope.ServiceProvider; 
    SeedData.initialize(service_provider);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
