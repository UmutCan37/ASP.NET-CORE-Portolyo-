using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    
    }
}
