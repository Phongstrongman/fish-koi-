using Managerment_fish.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("FishKoiDB")));

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





app.MapControllerRoute(
    name: "contact",
    pattern: "{controller=contact}/{action=Index}");

app.MapControllerRoute(
	name: "Quality",
	pattern: "{controller=Quality}/{action=Index}");




app.MapControllerRoute(
    name: "Treatment",
    pattern: "{controller=Treatment}/{action=Index}");

app.MapControllerRoute(
	name: "Service",
pattern: "{controller=Service}/{action=Index}");

app.MapControllerRoute(
    name: "FAQs",
    pattern: "{controller=FAQs}/{action=Index}");


app.MapControllerRoute(
	name: "Question",
	pattern: "{controller=Question}/{action=Index}");




app.MapControllerRoute(
    name: " Privacy Policy",
    pattern: "{controller= PrivacyPolicy}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Login",
    pattern: "{controller=Login}/{action=Index}");


app.Run();

