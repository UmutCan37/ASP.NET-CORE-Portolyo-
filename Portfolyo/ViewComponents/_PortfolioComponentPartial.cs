using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        PortfolyoContext Context = new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            var values = Context.Portfolios.ToList();
            return View(values);
        }

    }
}
