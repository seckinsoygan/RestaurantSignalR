using Microsoft.AspNetCore.Mvc;

namespace SignalR.APP.ViewComponents.LayoutComponents
{
    public class _LayoutScriptsPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
