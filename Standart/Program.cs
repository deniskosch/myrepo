using NLog;
using NLog.Web;
using Standart.Models;
using Standart.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

builder.Services.AddHttpClient();
builder.Services.AddAutoMapper(typeof(AddressProfile));
builder.Services.AddScoped<IAddressService, AddressService>();

// Добавьте эту строку для поддержки представлений
builder.Services.AddControllersWithViews(); // Регистрация MVC с поддержкой представлений

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Address API", Version = "v1" });
});

builder.Logging.ClearProviders();
builder.Host.UseNLog();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Address API v1");
        c.RoutePrefix = string.Empty;
    });
}

app.MapGet("/", () => Results.Redirect("/api/address"));
app.MapControllerRoute(
    name: "debug",
    pattern: "debug",
    defaults: new { controller = "Debug", action = "Index" }
);

app.UseCors("AllowAll");
app.UseAuthorization();
app.MapControllers();
app.Run();
