using TakeawayTitans.Components;
using Microsoft.EntityFrameworkCore;
using TakeawayTitans.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using TakeawayTitans;

DotNetEnv.Env.Load(".env.local"); // Load environment variables locally

var builder = WebApplication.CreateBuilder(args);

// Get database connection string (Render uses DATABASE_URL)
var connectionString = builder.Configuration.GetConnectionString("TakeawayTitansContext")
                       ?? Environment.GetEnvironmentVariable("DATABASE_URL");

if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("Connection string 'TakeawayTitansContext' not found.");
}

// ✅ Configure PostgreSQL
builder.Services.AddDbContextFactory<TakeawayTitansContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddBlazorBootstrap();

// ✅ Razor Components setup
builder.Services.AddRazorComponents()
       .AddInteractiveServerComponents();

// ✅ Environment-aware HttpClient
builder.Services.AddScoped(sp =>
{
    // Try to get BaseUrl from environment (used in Render)
    var baseUrl = builder.Configuration["BaseUrl"] 
                  ?? Environment.GetEnvironmentVariable("BaseUrl");

    if (string.IsNullOrWhiteSpace(baseUrl))
    {
        // Local development (use relative path)
        return new HttpClient { BaseAddress = new Uri("/", UriKind.Relative) };
    }

    // Production (Render)
    return new HttpClient { BaseAddress = new Uri(baseUrl) };
});

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddHttpContextAccessor();

// ✅ Add Controllers for API endpoints
builder.Services.AddControllers();

var app = builder.Build();

// ✅ Configure the HTTP request pipeline
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

// ✅ Map Razor Components
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();