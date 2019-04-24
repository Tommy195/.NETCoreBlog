﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NET()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Docker()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult GuideNetCore()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult DockerInstall()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Extras()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult VideoNet()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult VideoDocker()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}