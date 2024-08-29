using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponenetsPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
