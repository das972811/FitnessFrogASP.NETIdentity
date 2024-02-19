using Microsoft.EntityFrameworkCore;

using FitnessFrogDb;
using FitnessFrogDb.Data;
using FitnessFrogDb.Models;

var builder = WebApplication.CreateBuilder(args);


string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Default connection string is null.");

builder.Services.AddDbContext<FitnessFrogContext>(options => options
    .UseMySQL(connectionString, x => x.MigrationsAssembly("FitnessFrogDb"))
);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IEntityService<Activity>, ActivitiesRepository>();
builder.Services.AddScoped<IEntityService<Entry>, EntriesRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Entries}/{action=Index}/{id?}");

app.Run();
