using TakeawayTitans.Components;
using Microsoft.EntityFrameworkCore;
using TakeawayTitans.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using TakeawayTitans.Services; // ShoppingCartService namespace
using TakeawayTitans;

DotNetEnv.Env.Load(".env.local"); // Load local environment variables

var builder = WebApplication.CreateBuilder(args);

// Get database connection string (Render uses DATABASE_URL)
var connectionString = builder.Configuration.GetConnectionString("TakeawayTitansContext")
                       ?? Environment.GetEnvironmentVariable("DATABASE_URL");

if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("Connection string 'TakeawayTitansContext' not found.");
}

// -------------------- Services --------------------

// Configure PostgreSQL
builder.Services.AddDbContextFactory<TakeawayTitansContext>(options =>
    options.UseNpgsql(connectionString));

// ✅ Shopping Cart - keep persistent across pages (singleton)
builder.Services.AddSingleton<ShoppingCartService>();

// QuickGrid and Blazor Bootstrap
builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddBlazorBootstrap();

// Razor Components setup
builder.Services.AddRazorComponents()
       .AddInteractiveServerComponents();

// HttpClient per user
builder.Services.AddScoped(sp =>
{
    var baseUrl = builder.Configuration["BaseUrl"]
                  ?? Environment.GetEnvironmentVariable("BaseUrl");

    if (string.IsNullOrWhiteSpace(baseUrl))
        return new HttpClient { BaseAddress = new Uri("/", UriKind.Relative) };

    return new HttpClient { BaseAddress = new Uri(baseUrl) };
});

// Authentication
builder.Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/admin-login";
        options.Cookie.Name = BlazorConstants.AuthCookieName;
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        options.SlidingExpiration = true;
    });

builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddHttpContextAccessor();

// Add Controllers for API endpoints
builder.Services.AddControllers();

var app = builder.Build();

// -------------------- HTTP Pipeline --------------------

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
app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery();

// Map API Controllers
app.MapControllers();

// Map Razor Components
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
