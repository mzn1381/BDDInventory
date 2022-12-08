using Inventory.Application.Contract.Inventory.Service;
using Inventory.Domain.Inventory.Repostiroy;
using Inventory.Infra.Inventory.Repository;
using Invnetory.Application;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Inventory.Infra.Context.InventoryDbContext>
(
    options => 
    {
        options.UseNpgsql("User ID=postgres;Password=00111381;Host=localhost;Port=5432;Database=InventoryBddProject;",opt=>
        {
            opt.MigrationsAssembly(new Inventory.Presentation.WeatherForecast().GetType().Assembly.ToString());
        });
    }
);
builder.Services.AddTransient<IInventoryService,InventoryService>();
builder.Services.AddTransient<IInventoryRepository,InventoryRepository>();

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

 public partial class Program { } 
