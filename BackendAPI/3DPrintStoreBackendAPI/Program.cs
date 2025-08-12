using Microsoft.EntityFrameworkCore;
using _3DPrintStoreBackendAPI.Models;
using Microsoft.AspNetCore.Identity;
using _3DPrintStoreBackendAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<PrintableContext>(opt =>
    opt.UseSqlServer(builder.Configuration["PrintStoreContext"]/*.GetConnectionString("DockerSQLServer")*/ /* ?? throw new InvalidOperationException("Connection string invalid")*/));

builder.Services.AddAuthorization();
builder.Services.AddAuthentication().AddCookie(IdentityConstants.ApplicationScheme)
    .AddBearerToken(IdentityConstants.BearerScheme);

builder.Services.AddIdentityCore<User>()
    .AddEntityFrameworkStores<SecurityDbContext>()
    .AddApiEndpoints();

builder.Services.AddDbContext<SecurityDbContext>(options =>
    options.UseSqlServer(builder.Configuration["PrintStoreSecurityDBContext"]));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.ApplyMigrations();
}

app.UseHttpsRedirection();

app.MapIdentityApi<User>();

app.UseAuthorization();

app.MapControllers();

app.Run();
