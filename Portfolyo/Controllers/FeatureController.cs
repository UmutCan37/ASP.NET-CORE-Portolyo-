using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;
using Portfolyo.DAL.Entities;

namespace Portfolyo.Controllers
{
	public class FeatureController : Controller
	{
		PortfolyoContext context = new PortfolyoContext();
		public IActionResult Index()
		{
			var values = context.Features.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateFeature()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateFeature(Feature feature)
		{
			context.Features.Add(feature);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteFeature(int id)
		{
			var value = context.Features.Find(id);
			context.Features.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateFeature(int id)
		{
			var value = context.Features.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateFeature(Feature feature)
		{
			context.Features.Update(feature);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
