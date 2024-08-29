using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;
using Portfolyo.DAL.Entities;

namespace Portfolyo.Controllers
{
	public class SocialMediaController : Controller
	{
		PortfolyoContext context = new PortfolyoContext();
		public IActionResult Index()
		{
			var values = context.SocialMedias.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateSocialMedia()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateSocialMedia(SocialMedia socialMedia)
		{
			context.SocialMedias.Add(socialMedia);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteSocialMedia(int id)
		{
			var value = context.SocialMedias.Find(id);
			context.SocialMedias.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateSocialMedia(int id)
		{
			var value = context.SocialMedias.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
		{
			context.SocialMedias.Update(socialMedia);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
