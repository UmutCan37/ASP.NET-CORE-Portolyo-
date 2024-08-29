using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        PortfolyoContext Context = new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            var values = Context.Testimonials.ToList();
            return View(values);
        }

    }
}
