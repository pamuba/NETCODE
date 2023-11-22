using StaticFilesDemos.Controllers;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddTransient<HomeController>();
builder.Services.AddControllers();
var app = builder.Build();

app.UseRouting();
app.MapControllers();
app.UseStaticFiles();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});

#region
//var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
//{
//    WebRootPath = "myroot"
//});

//var app = builder.Build();

//app.UseStaticFiles();//wwwroot
//app.UseStaticFiles(new StaticFileOptions()
//{
//    FileProvider = new PhysicalFileProvider(
//       Path.Combine(builder.Environment.ContentRootPath, "mywebroot")
//    )
//}); 
//app.UseRouting();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.Map("/", async context =>
//    {
//        await context.Response.WriteAsync("Home Page");
//    });
//});
#endregion

app.Run();
