using Microsoft.EntityFrameworkCore;
using Taqui.Database;
using Taqui.Models;
using Taqui.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<Repository<Cliente>>(); // Ajuste o tipo conforme necessário
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FIAPDBContext>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("OracleFIAP"));
});

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
