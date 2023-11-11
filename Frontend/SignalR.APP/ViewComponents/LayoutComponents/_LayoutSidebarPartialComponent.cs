using Microsoft.AspNetCore.Mvc;

namespace SignalR.APP.ViewComponents.LayoutComponents
{
    public class _LayoutSidebarPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
