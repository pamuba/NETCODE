
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRouting(options => {
    options.ConstraintMap.Add("months", typeof(middlewareDemo.CustomConstraints));
});
var app = builder.Build();

//Enble Routing 
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.Map("files/{filename=sample}.{extension=txt}", async (context) =>
    {
        string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);

        await context.Response.WriteAsync($"In Files-{fileName}.{extension}");
    });

    endpoints.Map("employee/profile/{EmployeeName=John}/{id=11}", async (context) =>
    {
        string? EmployeeName = Convert.ToString(context.Request.RouteValues["EmployeeName"]);
        string? ID = Convert.ToString(context.Request.RouteValues["id"]);
        await context.Response.WriteAsync($"Employee-{EmployeeName}-{ID}");
    });

    endpoints.Map("products/details/{id:int?}", async context =>
    {
        if (context.Request.RouteValues.ContainsKey("id"))
        {
            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            await context.Response.WriteAsync($"Product Details-{id}");
        }
        else {
            await context.Response.WriteAsync($"Product Details- Id is not provided");
        }
    });

    endpoints.Map("daily-reports/{reportdate:datetime}", async context =>
    {
        DateTime reportDate = Convert.ToDateTime(context.Request.RouteValues["reportdate"]);
        await context.Response.WriteAsync($"Daily Reported at: " +
            $"{reportDate.ToShortDateString()}");
    });


    endpoints.Map("cities/{cityid:guid}", async context =>
    {
        Guid cityId = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityid"]));
        await context.Response.WriteAsync($"City ID: " +
            $"{cityId}");
       
    });

    endpoints.Map("sales-report/{year:int:min(1900)}/{month:months}",
        async context =>
        {
            int year = Convert.ToInt32(context.Request.RouteValues["year"]);
            string month = Convert.ToString(context.Request.RouteValues["month"]);

            if (month == "apr" || month == "may")
            {
                await context.Response.WriteAsync($"Report for Month - {month}/{year}");
            }
            else {
                await context.Response.WriteAsync("Wrong Month");
            }
        });
});

app.Run(async context => {
    await context.Response.WriteAsync($"Request Received at {context.Request.Path}");
});

app.Run();