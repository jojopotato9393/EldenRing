using EldenRing.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EldenRing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        public async Task<IActionResult> Index()
        {
            var items = await ApiService.FetchItemsAsync();
            return ((IActionResult)items);
        }
    }
}
