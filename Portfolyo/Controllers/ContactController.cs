using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;
using Portfolyo.DAL.Entities;

namespace Portfolyo.Controllers
{
	public class ContactController : Controller
	{
		PortfolyoContext context = new PortfolyoContext();
		public IActionResult Index()
		{
			var values = context.Contacts.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateContact()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateContact(Contact contact)
		{
			context.Contacts.Add(contact);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteContact(int id)
		{
			var value = context.Contacts.Find(id);
			context.Contacts.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateContact(int id)
		{
			var value = context.Contacts.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateContact(Contact contact)
		{
			context.Contacts.Update(contact);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
