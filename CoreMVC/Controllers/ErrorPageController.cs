﻿using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1()
        {
            return View();
        }
    }
}
