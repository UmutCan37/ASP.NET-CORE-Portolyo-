using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        PortfolyoContext portfolyoContext=new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            var values=portfolyoContext.Features.ToList();
            return View(values);
        }
    
    }
}
