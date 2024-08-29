﻿using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;
using Portfolyo.DAL.Entities;

namespace Portfolyo.Controllers
{
	public class PortfolioController : Controller
	{
		PortfolyoContext context = new PortfolyoContext();
		public IActionResult Index()
		{
			var values = context.Portfolios.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreatePortfolio()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreatePortfolio(Portfolio portfolio)
		{
			context.Portfolios.Add(portfolio);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeletePortfolio(int id)
		{
			var value = context.Portfolios.Find(id);
			context.Portfolios.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdatePortfolio(int id)
		{
			var value = context.Portfolios.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdatePortfolio(Portfolio portfolio)
		{
			context.Portfolios.Update(portfolio);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
