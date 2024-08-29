using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;
using Portfolyo.DAL.Entities;

namespace Portfolyo.Controllers
{
    public class ExperienceController : Controller
    {
        PortfolyoContext context = new PortfolyoContext();
        public IActionResult Index()
        {
            var values=context.Experiences.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
		public IActionResult CreateExperience(Experience experience)
		{
			context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("Index");
		}
        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
		}
        [HttpGet]
		public IActionResult UpdateExperience(int id)
        {
			var value = context.Experiences.Find(id);
			return View(value);
		}
        [HttpPost]
		public IActionResult UpdateExperience(Experience experience)
		{
			context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("Index");
		}

	}
}
