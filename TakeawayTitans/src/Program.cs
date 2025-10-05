using TakeawayTitans.Components;
using Microsoft.EntityFrameworkCore;
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

// Use PostgreSQL
builder.Services.AddDbContextFactory<TakeawayTitansContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add Razor Components
builder.Services.AddRazorComponents()
       .AddInteractiveServerComponents();

// ✅ Register HttpClient for Blazor Server with BaseAddress
builder.Services.AddScoped(sp =>
{
    var baseAddress = builder.Configuration["BaseUrl"] ?? "http://localhost:5062/";
    return new HttpClient { BaseAddress = new Uri(baseAddress) };
});

// ✅ Add Controllers for API endpoints
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAntiforgery();

// ✅ Map API Controllers
app.MapControllers();

// Map Razor Components
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
