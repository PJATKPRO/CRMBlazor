using CRMBlazor.Server.Data.CRMBlazorDb;
using CRMBlazor.Server.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var mariaDbVersion = new MySqlServerVersion(new Version(5, 7));

builder.Services.AddDbContext<CRMBlazorDbContext>(options =>
{
#if DEBUG
    options.UseMySql(connectionString, mariaDbVersion)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors();

#else
    options.UseMySql(connectionString, mariaDbVersion);
#endif
}, ServiceLifetime.Transient);

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<CRMBlazorDbContext>();

builder.Services.AddIdentityServer()
    .AddApiAuthorization<ApplicationUser, CRMBlazorDbContext>();

builder.Services.AddAuthentication()
    .AddIdentityServerJwt();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();
app.UseAuthentication();
app.UseAuthorization();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");



app.Run();
