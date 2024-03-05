using EldenRing.Models;
using EldenRing.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EldenRing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //public async Task<IActionResult> Items()
        //{
        //    var items = await ApiService.FetchItemsAsync();
        //    return View(items);
        //}
        public async Task<IActionResult> YourActionName()
        {
            List<Items> items = await ApiService.FetchItemsAsync(); 
            var responseModel = new Response
            {
               Data = items
               
            };

            return View(responseModel);
        }

    }
}
