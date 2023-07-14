using theSite.Data;

var builder = WebApplication.CreateBuilder(args); // Create a WebApplicationBuilder instance.

builder.Services.AddDbContext<AppDbContext>(options =>
{
    // Configure your database context
    // Add the AppDbContext to the service container.
});

builder.Services.AddControllersWithViews(); // Add controllers and views support to the service container.

var app = builder.Build(); // Build the WebApplication instance.

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