﻿using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
