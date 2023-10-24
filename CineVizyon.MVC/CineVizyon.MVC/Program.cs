using CineVizyon.MVC.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//appsettings.json kullanýmý için;
var settings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>();//json'dan çekilen verilerle appsettigs tipindeki clasý doldurduk.
builder.Services.AddSingleton(settings);
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
