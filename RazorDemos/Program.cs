var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();
app.MapControllers();

app.UseStaticFiles();

app.UseRouting();

app.Run();
