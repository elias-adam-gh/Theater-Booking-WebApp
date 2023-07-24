using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using theSite.Data;


var builder = WebApplication.CreateBuilder(args); // Create a WebApplicationBuilder instance.

builder.Services.AddDbContext<AppDbContext>(options =>
{
    // Retrieve the connection string from the appsettings.json file
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString");

    // Configure your database context with the connection string
    options.UseSqlServer(connectionString);
});

builder.Services.AddControllersWithViews(); // Add controllers and views support to the service container.

var app = builder.Build(); // Build the WebApplication instance.

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    AppDbInitializer.Seed(dbContext); // Call the Seed method from AppDbInitializer class
    Debug.WriteLine("AppDbInitializer.Seed method has been called.");
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // Add exception handling middleware.
    app.UseHsts(); // Add HTTP Strict Transport Security (HSTS) middleware.
}

app.UseHttpsRedirection(); // Add HTTP to HTTPS redirection middleware.
app.UseStaticFiles(); // Add static files middleware.

app.UseRouting(); // Add routing middleware.

app.UseAuthorization(); // Add authorization middleware.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Map the default controller route.

app.Run(); // Start the application and listen for incoming HTTP requests.