using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponenetPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	
	}
}
