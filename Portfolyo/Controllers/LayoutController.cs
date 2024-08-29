using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
