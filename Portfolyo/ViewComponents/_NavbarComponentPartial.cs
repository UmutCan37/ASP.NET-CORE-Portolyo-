using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
