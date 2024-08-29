using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.Controllers
{
	public class StatisticController : Controller
	{
		PortfolyoContext context = new PortfolyoContext();
		public IActionResult Index()
		{
			ViewBag.v1 = context.Skills.Count();
			ViewBag.v2 = context.Messages.Count();
			ViewBag.v3 = context.Messages.Where(x=>x.IsRead==false).Count();
			ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
			return View();
		}
	}
}
