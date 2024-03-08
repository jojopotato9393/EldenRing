using EldenRing.Models;
using EldenRing.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EldenRing.Controllers;
public class ItemsController : Controller
{
    public IActionResult Index()
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
    public async Task<IActionResult> ItemAction()
    {
        //List<Items> items = await ApiService.FetchItemsAsync();
        //var responseModel = new Response
        //{
        //    Data = items

        //};

        //return View(responseModel);
        var response = await ApiService.FetchItemsAsync();
        return View(response);
    }
}
