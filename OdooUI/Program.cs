using Core.Core.Context;
using Core.Core.Entities;
using Core.Services;
using Core.Services.Employees;
using Core.Services.Inventory;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connetion = builder.Configuration.GetConnectionString("PostgreSqlConnection");
builder.Services.AddDbContext<DbOdooContext>(options =>
   options.UseNpgsql(connetion)
   );

#region Services
builder.Services.AddScoped<ServiceInit>();
builder.Services.AddScoped<ServiceMain>();
builder.Services.AddScoped<ServiceOdoo>();
//Employees
builder.Services.AddScoped<HrDepartmentService>();
builder.Services.AddScoped<HrEmployeeService>();
builder.Services.AddScoped<HrWorkLocationService>();
builder.Services.AddScoped<HrDepartureReasonService>();
builder.Services.AddScoped<HrSkillService>();
builder.Services.AddScoped<HrJobService>();
builder.Services.AddScoped<HrPlanService>();
builder.Services.AddScoped<HrEmployeeCategoryService>();
builder.Services.AddScoped<Product_CategoryService>();
#endregion


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
