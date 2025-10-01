using TakeawayTitans.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TakeawayTitans.Data;
DotNetEnv.Env.Load(".env.local"); // Load environment variables from .env.local

var builder = WebApplication.CreateBuilder(args);

// Get the connection string from appsettings.json or .env.local
var connectionString = builder.Configuration.GetConnectionString("TakeawayTitansContext")
                       ?? Environment.GetEnvironmentVariable("DATABASE_URL");

if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("Connection string 'TakeawayTitansContext' not found.");
}

// Use PostgreSQL instead of SQL Server
builder.Services.AddDbContextFactory<TakeawayTitansContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
