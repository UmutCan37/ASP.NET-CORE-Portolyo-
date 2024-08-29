using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents
{
    public class _ContactCompenentPartial : ViewComponent
    {
        PortfolyoContext Context = new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            var values = Context.Contacts.ToList();
            return View(values);
        }
    
    }
}
