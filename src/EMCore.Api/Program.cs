using EMCore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "EMCore API", Version = "v1" });
});

// EF Core - SQLite for development; swap to SQL Server in production
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? "Data Source=emcore.db";
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connectionString));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseStaticFiles();
app.UseDefaultFiles();
app.UseAuthorization();
app.MapControllers();

// Serve the SPA for any non-API route (fallback)
app.MapFallbackToFile("index.html");

app.Run();
