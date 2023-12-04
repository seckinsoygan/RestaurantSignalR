using Microsoft.AspNetCore.Mvc;

namespace SignalR.APP.Controllers
{
    public class SignalRDefault : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
