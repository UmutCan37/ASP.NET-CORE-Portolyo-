using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        PortfolyoContext portfolyoContext=new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle= portfolyoContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = portfolyoContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetails = portfolyoContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    
    }
}
