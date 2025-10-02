using TakeawayTitans.Components;
using Microsoft.EntityFrameworkCore;
using TakeawayTitans.Data;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);
var useSqlite = builder.Configuration.GetValue<bool>("UseSqlite");

Action<DbContextOptionsBuilder> configureDbContext = options =>
{
    if (useSqlite)
    {
        var sqliteConnection = builder.Configuration.GetConnectionString("Sqlite") ?? "Data Source=app.db";
        options.UseSqlite(sqliteConnection);
    }
    else
    {
        var sqlServerConnection = builder.Configuration.GetConnectionString("TakeawayTitansContext")
            ?? throw new InvalidOperationException("Connection string 'TakeawayTitansContext' not found");
        options.UseSqlServer(sqlServerConnection);
    }
};

builder.Services.AddDbContextFactory<TakeawayTitansContext>(configureDbContext);

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddBlazorBootstrap();


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.Name = "auth_token";
        options.LoginPath = "/admin-login";
        options.Cookie.MaxAge = TimeSpan.FromMinutes(30);
        options.AccessDeniedPath = "/access-denied";
    });
builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddControllers();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
