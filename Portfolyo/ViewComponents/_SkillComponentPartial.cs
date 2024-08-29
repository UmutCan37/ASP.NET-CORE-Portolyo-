using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        PortfolyoContext Context = new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            var values=Context.Skills.ToList();
            return View(values);
        }
    }
}
