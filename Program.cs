using LunaEdgeTestTask.Data;
using LunaEdgeTestTask.Interfaces;
using LunaEdgeTestTask.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json");
var configuration = builder.Configuration;

// Services configuration
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        string? issuer = configuration.GetSection("JWT:Issuer").Get<string>();
        string? audience = configuration.GetSection("JWT:Audience").Get<string>();
        string? key = configuration.GetSection("JWT:Key").Get<string>();
        
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateAudience = true,
            ValidateIssuer = true,
            ValidateLifetime = true,
            ValidIssuer = issuer,
            ValidAudience = audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.Unicode.GetBytes(key)),    
        };
    });
builder.Services.AddAuthorization();

builder.Services.AddDbContext<LunaEdgeDbContext>(options =>
{
    string? connectionString = configuration.GetConnectionString("LocalConnection");
    options.UseSqlServer(connectionString);
});

builder.Services.AddTransient<IRepository, SqlRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Middleware configuration
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthorization();

app.MapControllers();

app.Run();
