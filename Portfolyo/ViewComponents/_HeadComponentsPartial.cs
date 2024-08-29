using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents
{
    public class _HeadComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
