using Microsoft.EntityFrameworkCore;
using Services.Employees;
using Services.EntityFrameworkCore.Context;
using Services.EntityFrameworkCore.Employees;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IEmployeeManagementService, EmployeeManagementService>();

builder.Services.AddDbContext<TasksManagementContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
