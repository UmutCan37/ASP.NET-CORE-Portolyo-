using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        PortfolyoContext Context = new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            var values = Context.Experiences.ToList();
            return View(values);
        }
    
    }
}
