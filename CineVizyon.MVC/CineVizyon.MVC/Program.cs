using CineVizyon.MVC.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//appsettings.json kullan�m� i�in;
var settings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>();//json'dan �ekilen verilerle appsettigs tipindeki clas� doldurduk.
builder.Services.AddSingleton(settings);
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
