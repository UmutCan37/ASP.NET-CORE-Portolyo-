using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;
using Portfolyo.DAL.Entities;

namespace Portfolyo.Controllers
{
	public class TestimonialController : Controller
	{
		PortfolyoContext context = new PortfolyoContext();
		public IActionResult Index()
		{
			var values = context.Testimonials.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateTestimonial()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateTestimonial(Testimonial testimonial)
		{
			context.Testimonials.Add(testimonial);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteTestimonial(int id)
		{
			var value = context.Testimonials.Find(id);
			context.Testimonials.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateTestimonial(int id)
		{
			var value = context.Testimonials.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			context.Testimonials.Update(testimonial);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
