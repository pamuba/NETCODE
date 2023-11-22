using CodeDemoEmpty.CustomMiddleware;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>();
var app = builder.Build();

//1st Middleware
//app.Use(async (HttpContext context, RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("Hello from before next\n");
//    await next(context);
//    await context.Response.WriteAsync("Hello from after next\n");
//});

//2nd Middleware
//app.UseMiddleware<MyCustomMiddleware>();
//app.UseMyCustomMiddleware();
//app.Use(async (HttpContext context, RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("2nd Middleware\n");
//    await next(context);
//    await context.Response.WriteAsync("2nd Middleware\n");
//});


//app.UseHelloCustomMiddleware();


////3rd Middleware
//app.Run(async (HttpContext context) =>
//{
//    await context.Response.WriteAsync("3nd Middleware\n");
//});

//app.UseWhen(
//    context => context.Request.Query.ContainsKey("username"),
//    app =>
//    {
//        app.Use(async (context, next) =>
//        {
//            await context.Response.WriteAsync("Hello from Middleware branch");
//            await next();
//        });
//    }
//);


//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Hello at middlewware branch");
//    await next();
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello at middlewware branch last");
//});

app.Use(async (context, next) =>
{
    Endpoint endpoint = context.GetEndpoint();
    await next();
});

//enable Routing
app.UseRouting();

app.Use(async (context, next) =>
{
    Endpoint endpoint = context.GetEndpoint();
    await next();
});

//creating endpoints
app.UseEndpoints(endpoints => {
    //add your endpoints here
    endpoints.MapGet("map1", async (context) =>
    {
        await context.Response.WriteAsync("In Map 1");
    });

    endpoints.MapPost("map2", async (context) =>
    {
        await context.Response.WriteAsync("In Map 2");
    });

    endpoints.Map("/", async (context) =>
    {
        await context.Response.WriteAsync("In /");
    });

    endpoints.Map("files/{filename=movie}.{extension=txt}", async (context) =>
    {
        string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"In Files-{fileName}.{extension}");
    });

    endpoints.Map("emp/{empname=movie}", async (context) =>
    {
        string? empname = Convert.ToString(context.Request.RouteValues["empname"]);
        await context.Response.WriteAsync($"In Emp-{empname}");
    });

});

app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});
app.Run();
