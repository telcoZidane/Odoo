using Core.Services.Employees;
using Core.Services.Inventory;
using Core.Services;
using Microsoft.EntityFrameworkCore;
using OdooApi.Models;
using OdooApi.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var connectionString = builder.Configuration.GetConnectionString("PostgreSqlConnection");
var SqlconnectionString = builder.Configuration.GetConnectionString("LeociaConnection");
builder.Services.AddDbContext<LeociaContext>(options =>
   options.UseSqlServer(SqlconnectionString)
   );

#region Services
builder.Services.AddScoped<ServiceInit>();
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
//Inventory
builder.Services.AddScoped<Product_CategoryService>();
builder.Services.AddScoped<ProductFamilyService>();
#endregion

builder.Services.AddControllers().AddNewtonsoftJson(x =>
   x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
