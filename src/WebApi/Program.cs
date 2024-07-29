using MrClean.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddWebServices();
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi();

    // set up cors
    app.UseCors(policy =>
    {
        policy.AllowAnyHeader();
        policy.WithOrigins("http://localhost:5010");
    });

    // init db
    await app.InitialiseDatabaseAsync();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseExceptionHandler(options => { });
app.Map("/", () => Results.Redirect("/swagger"));
app.MapEndpoints();

app.Run();

public partial class Program { }
