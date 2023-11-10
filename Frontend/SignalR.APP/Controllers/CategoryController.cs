using Microsoft.AspNetCore.Mvc;

namespace SignalR.APP.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
