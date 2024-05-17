using GestionEnseignants.Models;
using GestionEnseignants.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using GestionEnseignants.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextPool<EnseignantContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("EnseignantDBConnection")));

builder.Services.AddDefaultIdentity<GestionEnseignantsUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<EnseignantContext>();
builder.Services.AddScoped<IDepartementRepository<Departement>, DepartementRepository>();
builder.Services.AddScoped<IEnseignantRepository <Enseignant>, EnseignantRepository>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
app.MapRazorPages();

app.Run();
