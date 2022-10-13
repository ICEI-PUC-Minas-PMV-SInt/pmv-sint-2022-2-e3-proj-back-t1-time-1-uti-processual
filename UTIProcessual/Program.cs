using Microsoft.EntityFrameworkCore;
using UTIProcessual.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DB Connection
string connectionString = builder.Configuration.GetConnectionString("DBConnection");
ServerVersion sv = MariaDbServerVersion.AutoDetect(connectionString);

builder.Services.AddDbContext<MVCDbContext>(options =>
    options.UseMySql(connectionString, sv));

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

app.Run();
