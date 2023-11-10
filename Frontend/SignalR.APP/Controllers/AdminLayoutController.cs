using Microsoft.AspNetCore.Mvc;

namespace SignalR.APP.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
