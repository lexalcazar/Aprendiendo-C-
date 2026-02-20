using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using MiApi.Data;
var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Swagger (Swashbuckle)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//cargar .env
Env.Load();

// Leer variable
var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION");
if (string.IsNullOrWhiteSpace(connectionString))
    throw new Exception("Falta DB_CONNECTION en el archivo .env");

// EF + SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString)
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();