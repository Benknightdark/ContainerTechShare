using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DockerMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DockerMVC.Controllers {
    public class HomeController : Controller {
        public IConfiguration Configuration { get; }
        public HomeController (IConfiguration configuration) {
            Configuration = configuration;

        }
        public IActionResult Index () {
            ViewData["FooterText"] = Configuration.GetValue<string> ("FooterText");
            return View ();
        }

        public IActionResult About () {
            ViewData["Message"] = "Your application description page.";
            ViewData["FooterText"] = Configuration.GetValue<string> ("FooterText");

            return View ();
        }

        public IActionResult Contact () {
            ViewData["Message"] = "Your contact page.";
            ViewData["FooterText"] = Configuration.GetValue<string> ("FooterText");

            return View ();
        }

        public IActionResult Privacy () {
            ViewData["FooterText"] = Configuration.GetValue<string> ("FooterText");

            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            ViewData["FooterText"] = Configuration.GetValue<string> ("FooterText");

            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}