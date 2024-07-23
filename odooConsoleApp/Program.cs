using Core.Services;
using Core.Services.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Odoo.Concrete;
using OdooApi.Data.Services;
using Microsoft.AspNetCore.Builder;
using Core.Services.Employees;
using odooConsoleApp;
using Core.Core.Context;



var builder = WebApplication.CreateBuilder(args);
// Create a host builder
var leociaconnectionString = builder.Configuration.GetConnectionString("LeociaConnection");

builder.Services.AddDbContext<DbOdooContext>(options =>
{
    options.UseSqlServer(leociaconnectionString);
    options.LogTo(Console.WriteLine);
});



// Register services
#region Services
builder.Services.AddTransient<ServiceInit>();
builder.Services.AddScoped<ServiceMain>();
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
builder.Services.AddScoped<ProductFamilyService>();
builder.Services.AddScoped<AssetFamilyService>();
builder.Services.AddDbContext<LeociaAppContext>();
builder.Services.AddScoped<RpcConnection>(); // Assuming you also register RpcConnection
#endregion

var app = builder.Build();

// call the process method
var _assetfamilyservice = app.Services.GetRequiredService<AssetFamilyService>();
await _assetfamilyservice.processProductCategory();