using CineVizyon.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CineVizyon.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _appSettings;
        public HomeController(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public async Task< IActionResult> Index()
        {
            ViewBag.AppName = _appSettings.ApplicationName;
            var getAllUrl=$"{_appSettings.ApiBaseUrl}/movies";
            using var client=new HttpClient();
            var responce=await client.GetFromJsonAsync<List<MovieFormViewModel>>(getAllUrl);
            return View(responce);
        }
    }
}
