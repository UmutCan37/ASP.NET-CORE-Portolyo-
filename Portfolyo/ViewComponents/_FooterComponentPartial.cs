using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    
    }
}
