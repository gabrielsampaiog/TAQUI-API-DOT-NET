using Microsoft.EntityFrameworkCore;
using Taqui.Database;
using Taqui.Models;
using Taqui.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<Repository<Cliente>>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Taqui API",
        Version = "v1",
        Description = "API para cadastrar clientes",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Grupo TAQUI",
            Email = "rm551325@fiap.com.br",
            Url = new Uri("https://github.com/RenatoRussano/OficialTaqui")
        }
    });
});

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
