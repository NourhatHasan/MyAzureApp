using MyAzureApp.Application.Services.interfaces;

var builder = WebApplication.CreateBuilder(args);

// Konfigurer DI
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registrer tjenester fra Application-laget
builder.Services.AddScoped<IExampleService, ExampleService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

app.Run();