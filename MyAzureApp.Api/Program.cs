using Microsoft.EntityFrameworkCore;
using MyAzureApp.Application.Services.interfaces;
using MyAzureApp.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Konfigurer DI
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registrer tjenester fra Application-laget
builder.Services.AddScoped<IExampleService, ExampleService>();
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

app.Run();